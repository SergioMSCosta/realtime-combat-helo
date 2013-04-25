namespace RTCH_Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxTCP = new System.Windows.Forms.GroupBox();
            this.btnTCPSend = new System.Windows.Forms.Button();
            this.txtTCPMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxTCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(8, 23);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(483, 344);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbLog);
            this.groupBox1.Location = new System.Drawing.Point(16, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 375);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxTCP);
            this.groupBox2.Controls.Add(this.btnConnectToServer);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(500, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP Connection";
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
            this.gbxTCP.Size = new System.Drawing.Size(481, 154);
            this.gbxTCP.TabIndex = 9;
            this.gbxTCP.TabStop = false;
            this.gbxTCP.Text = "Send Message";
            // 
            // btnTCPSend
            // 
            this.btnTCPSend.Location = new System.Drawing.Point(371, 116);
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
            this.txtTCPMessage.Size = new System.Drawing.Size(368, 82);
            this.txtTCPMessage.TabIndex = 3;
            this.txtTCPMessage.Text = "{\"channel\":\"ch:session1\",\"data\":{\"id\":\"ah64_1\",\"type\":\"ah64\",\"hdg\":\"60\",\"alt\":\"20" +
    "00\",\"loc\":{\"x\":\"300\",\"y\":\"200\"},\"spd\":\"150\"}}";
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
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(8, 23);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(145, 28);
            this.btnConnectToServer.TabIndex = 6;
            this.btnConnectToServer.Text = "&Connect to Server";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(441, 626);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 28);
            this.btnClearLog.TabIndex = 12;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 667);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(557, 714);
            this.MinimumSize = new System.Drawing.Size(557, 714);
            this.Name = "frmMain";
            this.Text = "RTCH Client";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbxTCP.ResumeLayout(false);
            this.gbxTCP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxTCP;
        private System.Windows.Forms.Button btnTCPSend;
        private System.Windows.Forms.TextBox txtTCPMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Button btnClearLog;

    }
}

