
namespace S7NetD2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPBaglanti = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMotorClose = new System.Windows.Forms.Button();
            this.btnMotorRun = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbCpu = new System.Windows.Forms.ComboBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadWrite = new System.Windows.Forms.TabPage();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPBaglanti.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPBaglanti);
            this.tabControl1.Controls.Add(this.ReadWrite);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPBaglanti
            // 
            this.tabPBaglanti.Controls.Add(this.label5);
            this.tabPBaglanti.Controls.Add(this.groupBox2);
            this.tabPBaglanti.Controls.Add(this.btnDisconnect);
            this.tabPBaglanti.Controls.Add(this.btnConnect);
            this.tabPBaglanti.Controls.Add(this.groupBox1);
            this.tabPBaglanti.Location = new System.Drawing.Point(4, 25);
            this.tabPBaglanti.Name = "tabPBaglanti";
            this.tabPBaglanti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBaglanti.Size = new System.Drawing.Size(768, 397);
            this.tabPBaglanti.TabIndex = 0;
            this.tabPBaglanti.Text = "Bağlantı";
            this.tabPBaglanti.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(376, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnMotorClose);
            this.groupBox2.Controls.Add(this.btnMotorRun);
            this.groupBox2.Location = new System.Drawing.Point(376, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::S7NetD2.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(68, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnMotorClose
            // 
            this.btnMotorClose.Location = new System.Drawing.Point(180, 157);
            this.btnMotorClose.Name = "btnMotorClose";
            this.btnMotorClose.Size = new System.Drawing.Size(111, 41);
            this.btnMotorClose.TabIndex = 1;
            this.btnMotorClose.Text = "Kapat";
            this.btnMotorClose.UseVisualStyleBackColor = true;
            this.btnMotorClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMotorRun
            // 
            this.btnMotorRun.Location = new System.Drawing.Point(47, 157);
            this.btnMotorRun.Name = "btnMotorRun";
            this.btnMotorRun.Size = new System.Drawing.Size(111, 41);
            this.btnMotorRun.TabIndex = 0;
            this.btnMotorRun.Text = "Çalıştır";
            this.btnMotorRun.UseVisualStyleBackColor = true;
            this.btnMotorRun.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(229, 221);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(141, 46);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(82, 221);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 46);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbCpu);
            this.groupBox1.Controls.Add(this.txtSlot);
            this.groupBox1.Controls.Add(this.txtRack);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı";
            // 
            // CbCpu
            // 
            this.CbCpu.FormattingEnabled = true;
            this.CbCpu.Location = new System.Drawing.Point(133, 38);
            this.CbCpu.Name = "CbCpu";
            this.CbCpu.Size = new System.Drawing.Size(186, 24);
            this.CbCpu.TabIndex = 9;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(133, 152);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(186, 22);
            this.txtSlot.TabIndex = 8;
            this.txtSlot.Text = "1";
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(133, 113);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(186, 22);
            this.txtRack.TabIndex = 7;
            this.txtRack.Text = "0";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(133, 78);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(186, 22);
            this.txtIp.TabIndex = 6;
            this.txtIp.Text = "192.168.0.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Slot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "IPadresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLC";
            // 
            // ReadWrite
            // 
            this.ReadWrite.Location = new System.Drawing.Point(4, 25);
            this.ReadWrite.Name = "ReadWrite";
            this.ReadWrite.Padding = new System.Windows.Forms.Padding(3);
            this.ReadWrite.Size = new System.Drawing.Size(768, 397);
            this.ReadWrite.TabIndex = 1;
            this.ReadWrite.Text = "Oku-Yaz";
            this.ReadWrite.UseVisualStyleBackColor = true;
            // 
            // saat
            // 
            this.saat.Enabled = true;
            this.saat.Interval = 1000;
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPBaglanti.ResumeLayout(false);
            this.tabPBaglanti.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPBaglanti;
        private System.Windows.Forms.TabPage ReadWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbCpu;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMotorClose;
        private System.Windows.Forms.Button btnMotorRun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer saat;
    }
}

