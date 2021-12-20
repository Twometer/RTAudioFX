namespace RTAudioFX
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInputDevice = new System.Windows.Forms.ComboBox();
            this.cbOutputDevice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshDevices = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPan = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb8D = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbDelay = new System.Windows.Forms.TrackBar();
            this.tbRoomSize = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoomSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output:";
            // 
            // cbInputDevice
            // 
            this.cbInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputDevice.FormattingEnabled = true;
            this.cbInputDevice.Location = new System.Drawing.Point(58, 19);
            this.cbInputDevice.Name = "cbInputDevice";
            this.cbInputDevice.Size = new System.Drawing.Size(199, 21);
            this.cbInputDevice.TabIndex = 2;
            // 
            // cbOutputDevice
            // 
            this.cbOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputDevice.FormattingEnabled = true;
            this.cbOutputDevice.Location = new System.Drawing.Point(58, 46);
            this.cbOutputDevice.Name = "cbOutputDevice";
            this.cbOutputDevice.Size = new System.Drawing.Size(199, 21);
            this.cbOutputDevice.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInputDevice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbOutputDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // btnRefreshDevices
            // 
            this.btnRefreshDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshDevices.Location = new System.Drawing.Point(29, 341);
            this.btnRefreshDevices.Name = "btnRefreshDevices";
            this.btnRefreshDevices.Size = new System.Drawing.Size(74, 23);
            this.btnRefreshDevices.TabIndex = 4;
            this.btnRefreshDevices.Text = "Refresh";
            this.btnRefreshDevices.UseVisualStyleBackColor = true;
            this.btnRefreshDevices.Click += new System.EventHandler(this.btnRefreshDevices_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(109, 341);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(189, 341);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDelay);
            this.groupBox2.Controls.Add(this.tbPan);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 135);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Controls";
            // 
            // tbPan
            // 
            this.tbPan.Location = new System.Drawing.Point(17, 73);
            this.tbPan.Maximum = 250;
            this.tbPan.Minimum = -250;
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(234, 45);
            this.tbPan.TabIndex = 9;
            this.tbPan.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPan.Scroll += new System.EventHandler(this.tbPan_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbRoomSize);
            this.groupBox3.Controls.Add(this.cb8D);
            this.groupBox3.Location = new System.Drawing.Point(12, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automation";
            // 
            // cb8D
            // 
            this.cb8D.AutoSize = true;
            this.cb8D.Location = new System.Drawing.Point(17, 32);
            this.cb8D.Name = "cb8D";
            this.cb8D.Size = new System.Drawing.Size(70, 17);
            this.cb8D.TabIndex = 0;
            this.cb8D.Text = "8D effect";
            this.cb8D.UseVisualStyleBackColor = true;
            this.cb8D.CheckedChanged += new System.EventHandler(this.cb8D_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(17, 22);
            this.tbDelay.Maximum = 250;
            this.tbDelay.Minimum = -250;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(234, 45);
            this.tbDelay.TabIndex = 10;
            this.tbDelay.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDelay.Scroll += new System.EventHandler(this.tbDelay_Scroll);
            // 
            // tbRoomSize
            // 
            this.tbRoomSize.Location = new System.Drawing.Point(115, 17);
            this.tbRoomSize.Maximum = 3000;
            this.tbRoomSize.Minimum = 1;
            this.tbRoomSize.Name = "tbRoomSize";
            this.tbRoomSize.Size = new System.Drawing.Size(142, 45);
            this.tbRoomSize.TabIndex = 11;
            this.tbRoomSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRoomSize.Value = 1;
            this.tbRoomSize.Scroll += new System.EventHandler(this.tbRoomSize_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRefreshDevices);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RTAudioFX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoomSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbInputDevice;
        private System.Windows.Forms.ComboBox cbOutputDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshDevices;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbPan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb8D;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar tbDelay;
        private System.Windows.Forms.TrackBar tbRoomSize;
    }
}

