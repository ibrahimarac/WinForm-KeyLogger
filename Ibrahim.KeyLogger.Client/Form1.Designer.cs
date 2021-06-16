namespace Ibrahim.KeyLogger.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.txtIp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStopRemoteScreen = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGetRemoteScreen = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemoteStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemoteStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbScreenPreview = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tmrScreen = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 121);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1005, 593);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lstKeys);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtIp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(997, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tuş Takibi";
            // 
            // lstKeys
            // 
            this.lstKeys.DisplayMember = "KeyName";
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 16;
            this.lstKeys.Location = new System.Drawing.Point(735, 121);
            this.lstKeys.Margin = new System.Windows.Forms.Padding(4);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.ScrollAlwaysVisible = true;
            this.lstKeys.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstKeys.Size = new System.Drawing.Size(204, 340);
            this.lstKeys.TabIndex = 15;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(732, 73);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(171, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Takip Edilen Tuşlar";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Location = new System.Drawing.Point(608, 25);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(80, 28);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 25);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(198, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Bağlanılacak Ip Adresi";
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Depth = 0;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Location = new System.Drawing.Point(857, 480);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.Primary = false;
            this.btnStop.Size = new System.Drawing.Size(79, 36);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Depth = 0;
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(735, 480);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = false;
            this.btnStart.Size = new System.Drawing.Size(77, 36);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.txtKeys);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(680, 452);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basılan Tuşlar";
            // 
            // txtKeys
            // 
            this.txtKeys.ForeColor = System.Drawing.Color.White;
            this.txtKeys.Location = new System.Drawing.Point(16, 33);
            this.txtKeys.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(640, 400);
            this.txtKeys.TabIndex = 0;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtIp.Depth = 0;
            this.txtIp.Hint = "";
            this.txtIp.Location = new System.Drawing.Point(247, 25);
            this.txtIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.Size = new System.Drawing.Size(331, 28);
            this.txtIp.TabIndex = 12;
            this.txtIp.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.pbScreenPreview);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(997, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ekran Yönetimi";
            // 
            // btnStopRemoteScreen
            // 
            this.btnStopRemoteScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopRemoteScreen.Depth = 0;
            this.btnStopRemoteScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStopRemoteScreen.Location = new System.Drawing.Point(21, 101);
            this.btnStopRemoteScreen.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnStopRemoteScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStopRemoteScreen.Name = "btnStopRemoteScreen";
            this.btnStopRemoteScreen.Primary = false;
            this.btnStopRemoteScreen.Size = new System.Drawing.Size(177, 36);
            this.btnStopRemoteScreen.TabIndex = 5;
            this.btnStopRemoteScreen.Text = "Bitir";
            this.btnStopRemoteScreen.UseVisualStyleBackColor = true;
            this.btnStopRemoteScreen.Click += new System.EventHandler(this.btnStopRemoteScreen_Click);
            // 
            // btnGetRemoteScreen
            // 
            this.btnGetRemoteScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetRemoteScreen.Depth = 0;
            this.btnGetRemoteScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetRemoteScreen.Location = new System.Drawing.Point(21, 42);
            this.btnGetRemoteScreen.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGetRemoteScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetRemoteScreen.Name = "btnGetRemoteScreen";
            this.btnGetRemoteScreen.Primary = false;
            this.btnGetRemoteScreen.Size = new System.Drawing.Size(177, 36);
            this.btnGetRemoteScreen.TabIndex = 4;
            this.btnGetRemoteScreen.Text = "Başlat";
            this.btnGetRemoteScreen.UseVisualStyleBackColor = true;
            this.btnGetRemoteScreen.Click += new System.EventHandler(this.btnGetRemoteScreen_Click);
            // 
            // btnRemoteStop
            // 
            this.btnRemoteStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoteStop.Depth = 0;
            this.btnRemoteStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoteStop.Location = new System.Drawing.Point(21, 141);
            this.btnRemoteStop.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRemoteStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoteStop.Name = "btnRemoteStop";
            this.btnRemoteStop.Primary = false;
            this.btnRemoteStop.Size = new System.Drawing.Size(182, 36);
            this.btnRemoteStop.TabIndex = 3;
            this.btnRemoteStop.Text = "Bitir";
            this.btnRemoteStop.UseVisualStyleBackColor = true;
            this.btnRemoteStop.Click += new System.EventHandler(this.btnRemoteStop_Click);
            // 
            // btnRemoteStart
            // 
            this.btnRemoteStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoteStart.Depth = 0;
            this.btnRemoteStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoteStart.Location = new System.Drawing.Point(21, 67);
            this.btnRemoteStart.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRemoteStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoteStart.Name = "btnRemoteStart";
            this.btnRemoteStart.Primary = false;
            this.btnRemoteStart.Size = new System.Drawing.Size(182, 36);
            this.btnRemoteStart.TabIndex = 2;
            this.btnRemoteStart.Text = "Başlat";
            this.btnRemoteStart.UseVisualStyleBackColor = true;
            this.btnRemoteStart.Click += new System.EventHandler(this.btnRemoteStart_Click);
            // 
            // pbScreenPreview
            // 
            this.pbScreenPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbScreenPreview.Location = new System.Drawing.Point(13, 44);
            this.pbScreenPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pbScreenPreview.Name = "pbScreenPreview";
            this.pbScreenPreview.Size = new System.Drawing.Size(722, 509);
            this.pbScreenPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreenPreview.TabIndex = 1;
            this.pbScreenPreview.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 17);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(148, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Ekran Görüntüsü";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 85);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1000, 28);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tmrScreen
            // 
            this.tmrScreen.Tick += new System.EventHandler(this.tmrScreen_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.btnStopRemoteScreen);
            this.groupBox2.Controls.Add(this.btnGetRemoteScreen);
            this.groupBox2.Location = new System.Drawing.Point(757, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uzak Makine Ekran İzleme";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aqua;
            this.groupBox3.Controls.Add(this.btnRemoteStart);
            this.groupBox3.Controls.Add(this.btnRemoteStop);
            this.groupBox3.Location = new System.Drawing.Point(757, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 237);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uzak Makine Klavye Fare Kontrolü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 729);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Logger V 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstKeys;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnStop;
        private MaterialSkin.Controls.MaterialFlatButton btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pbScreenPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoteStop;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoteStart;
        private MaterialSkin.Controls.MaterialFlatButton btnGetRemoteScreen;
        private MaterialSkin.Controls.MaterialFlatButton btnStopRemoteScreen;
        private System.Windows.Forms.Timer tmrScreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

