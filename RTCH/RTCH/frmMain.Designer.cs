namespace RTCH
{
    partial class frmMain
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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnRunServer = new System.Windows.Forms.Button();
            this.btnConnectToORTC = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssTCPStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssORTCStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCPPort = new System.Windows.Forms.TextBox();
            this.gbxTCP = new System.Windows.Forms.GroupBox();
            this.btnTCPSend = new System.Windows.Forms.Button();
            this.txtTCPMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbxORTC = new System.Windows.Forms.GroupBox();
            this.btnORTCSendMessage = new System.Windows.Forms.Button();
            this.txtORTCMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtORTCChannel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxTCP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxORTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(8, 23);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(937, 322);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = "";
            // 
            // btnRunServer
            // 
            this.btnRunServer.Location = new System.Drawing.Point(162, 20);
            this.btnRunServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(100, 28);
            this.btnRunServer.TabIndex = 2;
            this.btnRunServer.Text = "&Run Server";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // btnConnectToORTC
            // 
            this.btnConnectToORTC.Location = new System.Drawing.Point(8, 23);
            this.btnConnectToORTC.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectToORTC.Name = "btnConnectToORTC";
            this.btnConnectToORTC.Size = new System.Drawing.Size(145, 28);
            this.btnConnectToORTC.TabIndex = 5;
            this.btnConnectToORTC.Text = "Connect to &ORTC";
            this.btnConnectToORTC.UseVisualStyleBackColor = true;
            this.btnConnectToORTC.Click += new System.EventHandler(this.btnConnectToORTC_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTCPStatus,
            this.tssORTCStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(978, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssTCPStatus
            // 
            this.tssTCPStatus.Name = "tssTCPStatus";
            this.tssTCPStatus.Size = new System.Drawing.Size(173, 20);
            this.tssTCPStatus.Text = "TCP Client: Disconnected";
            // 
            // tssORTCStatus
            // 
            this.tssORTCStatus.Name = "tssORTCStatus";
            this.tssORTCStatus.Size = new System.Drawing.Size(143, 20);
            this.tssORTCStatus.Text = "ORTC: Disconnected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbLog);
            this.groupBox1.Location = new System.Drawing.Point(16, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(953, 353);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTCPPort);
            this.groupBox2.Controls.Add(this.gbxTCP);
            this.groupBox2.Controls.Add(this.btnRunServer);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(470, 254);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP Connection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port:";
            // 
            // txtTCPPort
            // 
            this.txtTCPPort.Location = new System.Drawing.Point(55, 23);
            this.txtTCPPort.Name = "txtTCPPort";
            this.txtTCPPort.Size = new System.Drawing.Size(100, 22);
            this.txtTCPPort.TabIndex = 1;
            this.txtTCPPort.Text = "3000";
            // 
            // gbxTCP
            // 
            this.gbxTCP.Controls.Add(this.btnTCPSend);
            this.gbxTCP.Controls.Add(this.txtTCPMessage);
            this.gbxTCP.Controls.Add(this.label3);
            this.gbxTCP.Enabled = false;
            this.gbxTCP.Location = new System.Drawing.Point(11, 59);
            this.gbxTCP.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTCP.Name = "gbxTCP";
            this.gbxTCP.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTCP.Size = new System.Drawing.Size(431, 186);
            this.gbxTCP.TabIndex = 9;
            this.gbxTCP.TabStop = false;
            this.gbxTCP.Text = "Send Message";
            // 
            // btnTCPSend
            // 
            this.btnTCPSend.Location = new System.Drawing.Point(323, 115);
            this.btnTCPSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnTCPSend.Name = "btnTCPSend";
            this.btnTCPSend.Size = new System.Drawing.Size(100, 28);
            this.btnTCPSend.TabIndex = 4;
            this.btnTCPSend.Text = "Send";
            this.btnTCPSend.UseVisualStyleBackColor = true;
            this.btnTCPSend.Click += new System.EventHandler(this.btnTCPSend_Click);
            // 
            // txtTCPMessage
            // 
            this.txtTCPMessage.Location = new System.Drawing.Point(103, 26);
            this.txtTCPMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCPMessage.Multiline = true;
            this.txtTCPMessage.Name = "txtTCPMessage";
            this.txtTCPMessage.Size = new System.Drawing.Size(320, 82);
            this.txtTCPMessage.TabIndex = 3;
            this.txtTCPMessage.Text = "Hello world";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbxORTC);
            this.groupBox3.Controls.Add(this.btnConnectToORTC);
            this.groupBox3.Location = new System.Drawing.Point(499, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(470, 254);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ORTC";
            // 
            // gbxORTC
            // 
            this.gbxORTC.Controls.Add(this.btnORTCSendMessage);
            this.gbxORTC.Controls.Add(this.txtORTCMessage);
            this.gbxORTC.Controls.Add(this.label2);
            this.gbxORTC.Controls.Add(this.txtORTCChannel);
            this.gbxORTC.Controls.Add(this.label1);
            this.gbxORTC.Enabled = false;
            this.gbxORTC.Location = new System.Drawing.Point(9, 60);
            this.gbxORTC.Margin = new System.Windows.Forms.Padding(4);
            this.gbxORTC.Name = "gbxORTC";
            this.gbxORTC.Padding = new System.Windows.Forms.Padding(4);
            this.gbxORTC.Size = new System.Drawing.Size(453, 186);
            this.gbxORTC.TabIndex = 8;
            this.gbxORTC.TabStop = false;
            this.gbxORTC.Text = "Send Message";
            // 
            // btnORTCSendMessage
            // 
            this.btnORTCSendMessage.Location = new System.Drawing.Point(345, 150);
            this.btnORTCSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnORTCSendMessage.Name = "btnORTCSendMessage";
            this.btnORTCSendMessage.Size = new System.Drawing.Size(100, 28);
            this.btnORTCSendMessage.TabIndex = 8;
            this.btnORTCSendMessage.Text = "Send";
            this.btnORTCSendMessage.UseVisualStyleBackColor = true;
            this.btnORTCSendMessage.Click += new System.EventHandler(this.btnORTCSendMessage_Click);
            // 
            // txtORTCMessage
            // 
            this.txtORTCMessage.Location = new System.Drawing.Point(104, 60);
            this.txtORTCMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtORTCMessage.Multiline = true;
            this.txtORTCMessage.Name = "txtORTCMessage";
            this.txtORTCMessage.Size = new System.Drawing.Size(341, 82);
            this.txtORTCMessage.TabIndex = 7;
            this.txtORTCMessage.Text = "{\"id\":\"ah64_1\",\"type\":\"ah64\",\"hdg\":\"60\",\"alt\":\"2000\",\"loc\":{\"x\":\"300\",\"y\":\"200\"}," +
    "\"spd\":\"150\"}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // txtORTCChannel
            // 
            this.txtORTCChannel.Location = new System.Drawing.Point(104, 25);
            this.txtORTCChannel.Margin = new System.Windows.Forms.Padding(4);
            this.txtORTCChannel.Name = "txtORTCChannel";
            this.txtORTCChannel.Size = new System.Drawing.Size(341, 22);
            this.txtORTCChannel.TabIndex = 6;
            this.txtORTCChannel.Text = "ch:session1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel:";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(895, 636);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 28);
            this.btnClearLog.TabIndex = 10;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "frmMain";
            this.Text = "RTCH";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxTCP.ResumeLayout(false);
            this.gbxTCP.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbxORTC.ResumeLayout(false);
            this.gbxORTC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.Button btnConnectToORTC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssTCPStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssORTCStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbxORTC;
        private System.Windows.Forms.Button btnORTCSendMessage;
        private System.Windows.Forms.TextBox txtORTCMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtORTCChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTCP;
        private System.Windows.Forms.Button btnTCPSend;
        private System.Windows.Forms.TextBox txtTCPMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTCPPort;

    }
}

