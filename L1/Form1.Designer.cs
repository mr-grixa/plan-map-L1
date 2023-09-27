namespace L1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartStopUDPClientButton = new System.Windows.Forms.Button();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.SendUDPMessageButton = new System.Windows.Forms.Button();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.LocalIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_control = new System.Windows.Forms.PictureBox();
            this.up_T = new System.Windows.Forms.NumericUpDown();
            this.up_B = new System.Windows.Forms.NumericUpDown();
            this.up_F = new System.Windows.Forms.NumericUpDown();
            this.up_M = new System.Windows.Forms.NumericUpDown();
            this.up_N = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_control = new System.Windows.Forms.Label();
            this.UDPRegularSenderTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox_N = new System.Windows.Forms.CheckBox();
            this.checkBox_AI = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.pictureBox_map = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_shag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStopUDPClientButton
            // 
            this.StartStopUDPClientButton.Location = new System.Drawing.Point(355, 11);
            this.StartStopUDPClientButton.Name = "StartStopUDPClientButton";
            this.StartStopUDPClientButton.Size = new System.Drawing.Size(54, 42);
            this.StartStopUDPClientButton.TabIndex = 27;
            this.StartStopUDPClientButton.Text = "Start";
            this.StartStopUDPClientButton.UseVisualStyleBackColor = true;
            this.StartStopUDPClientButton.Click += new System.EventHandler(this.StartStopUDPClientButton_Click);
            // 
            // ReportListBox
            // 
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.Location = new System.Drawing.Point(20, 143);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.ScrollAlwaysVisible = true;
            this.ReportListBox.Size = new System.Drawing.Size(1013, 95);
            this.ReportListBox.TabIndex = 26;
            // 
            // SendUDPMessageButton
            // 
            this.SendUDPMessageButton.Location = new System.Drawing.Point(8, 104);
            this.SendUDPMessageButton.Name = "SendUDPMessageButton";
            this.SendUDPMessageButton.Size = new System.Drawing.Size(75, 28);
            this.SendUDPMessageButton.TabIndex = 25;
            this.SendUDPMessageButton.Text = "Send";
            this.SendUDPMessageButton.UseVisualStyleBackColor = true;
            this.SendUDPMessageButton.Click += new System.EventHandler(this.SendUDPMessageButton_Click);
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(248, 38);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocalPortTextBox.TabIndex = 22;
            this.LocalPortTextBox.Text = "7777";
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(248, 6);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocalIPTextBox.TabIndex = 21;
            this.LocalIPTextBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Local Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Local IP";
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(80, 38);
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemotePortTextBox.TabIndex = 18;
            this.RemotePortTextBox.Text = "8888";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(80, 6);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoteIPTextBox.TabIndex = 17;
            this.RemoteIPTextBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Remote Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Remote IP";
            // 
            // pictureBox_control
            // 
            this.pictureBox_control.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_control.Location = new System.Drawing.Point(668, 12);
            this.pictureBox_control.Name = "pictureBox_control";
            this.pictureBox_control.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_control.TabIndex = 30;
            this.pictureBox_control.TabStop = false;
            this.pictureBox_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_control_MouseDown);
            // 
            // up_T
            // 
            this.up_T.Location = new System.Drawing.Point(312, 73);
            this.up_T.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_T.Name = "up_T";
            this.up_T.Size = new System.Drawing.Size(43, 20);
            this.up_T.TabIndex = 46;
            this.up_T.ValueChanged += new System.EventHandler(this.up_T_ValueChanged);
            // 
            // up_B
            // 
            this.up_B.Location = new System.Drawing.Point(241, 73);
            this.up_B.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.up_B.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.up_B.Name = "up_B";
            this.up_B.Size = new System.Drawing.Size(43, 20);
            this.up_B.TabIndex = 45;
            this.up_B.ValueChanged += new System.EventHandler(this.up_B_ValueChanged);
            // 
            // up_F
            // 
            this.up_F.Location = new System.Drawing.Point(170, 73);
            this.up_F.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_F.Name = "up_F";
            this.up_F.Size = new System.Drawing.Size(43, 20);
            this.up_F.TabIndex = 44;
            this.up_F.ValueChanged += new System.EventHandler(this.up_F_ValueChanged);
            // 
            // up_M
            // 
            this.up_M.Location = new System.Drawing.Point(100, 73);
            this.up_M.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_M.Name = "up_M";
            this.up_M.Size = new System.Drawing.Size(43, 20);
            this.up_M.TabIndex = 43;
            this.up_M.ValueChanged += new System.EventHandler(this.up_M_ValueChanged);
            // 
            // up_N
            // 
            this.up_N.Location = new System.Drawing.Point(27, 73);
            this.up_N.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.up_N.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.up_N.Name = "up_N";
            this.up_N.Size = new System.Drawing.Size(43, 20);
            this.up_N.TabIndex = 42;
            this.up_N.ValueChanged += new System.EventHandler(this.up_N_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "T";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "M";
            // 
            // label_control
            // 
            this.label_control.AutoSize = true;
            this.label_control.Location = new System.Drawing.Point(5, 77);
            this.label_control.Name = "label_control";
            this.label_control.Size = new System.Drawing.Size(15, 13);
            this.label_control.TabIndex = 37;
            this.label_control.Text = "N";
            // 
            // UDPRegularSenderTimer
            // 
            this.UDPRegularSenderTimer.Interval = 1000;
            // 
            // checkBox_N
            // 
            this.checkBox_N.AutoSize = true;
            this.checkBox_N.Location = new System.Drawing.Point(90, 114);
            this.checkBox_N.Name = "checkBox_N";
            this.checkBox_N.Size = new System.Drawing.Size(46, 17);
            this.checkBox_N.TabIndex = 47;
            this.checkBox_N.Text = "N++";
            this.checkBox_N.UseVisualStyleBackColor = true;
            // 
            // checkBox_AI
            // 
            this.checkBox_AI.AutoSize = true;
            this.checkBox_AI.Location = new System.Drawing.Point(214, 115);
            this.checkBox_AI.Name = "checkBox_AI";
            this.checkBox_AI.Size = new System.Drawing.Size(79, 17);
            this.checkBox_AI.TabIndex = 48;
            this.checkBox_AI.Text = "Автопилот";
            this.checkBox_AI.UseVisualStyleBackColor = true;
            this.checkBox_AI.CheckedChanged += new System.EventHandler(this.checkBox_AI_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Remote Port";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(24, 368);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(19, 13);
            this.label_X.TabIndex = 50;
            this.label_X.Text = "16";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Y";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(69, 368);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(19, 13);
            this.label_Y.TabIndex = 52;
            this.label_Y.Text = "10";
            // 
            // pictureBox_map
            // 
            this.pictureBox_map.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_map.Location = new System.Drawing.Point(153, 244);
            this.pictureBox_map.Name = "pictureBox_map";
            this.pictureBox_map.Size = new System.Drawing.Size(320, 200);
            this.pictureBox_map.TabIndex = 54;
            this.pictureBox_map.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_shag
            // 
            this.label_shag.AutoSize = true;
            this.label_shag.Location = new System.Drawing.Point(309, 118);
            this.label_shag.Name = "label_shag";
            this.label_shag.Size = new System.Drawing.Size(32, 13);
            this.label_shag.TabIndex = 55;
            this.label_shag.Text = "Shag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.label_shag);
            this.Controls.Add(this.pictureBox_map);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_AI);
            this.Controls.Add(this.checkBox_N);
            this.Controls.Add(this.up_T);
            this.Controls.Add(this.up_B);
            this.Controls.Add(this.up_F);
            this.Controls.Add(this.up_M);
            this.Controls.Add(this.up_N);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_control);
            this.Controls.Add(this.pictureBox_control);
            this.Controls.Add(this.StartStopUDPClientButton);
            this.Controls.Add(this.ReportListBox);
            this.Controls.Add(this.SendUDPMessageButton);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.LocalIPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemotePortTextBox);
            this.Controls.Add(this.RemoteIPTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Щербинин Григорий 201-325";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartStopUDPClientButton;
        private System.Windows.Forms.ListBox ReportListBox;
        private System.Windows.Forms.Button SendUDPMessageButton;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_control;
        private System.Windows.Forms.NumericUpDown up_T;
        private System.Windows.Forms.NumericUpDown up_B;
        private System.Windows.Forms.NumericUpDown up_F;
        private System.Windows.Forms.NumericUpDown up_M;
        private System.Windows.Forms.NumericUpDown up_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_control;
        private System.Windows.Forms.Timer UDPRegularSenderTimer;
        private System.Windows.Forms.CheckBox checkBox_N;
        private System.Windows.Forms.CheckBox checkBox_AI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.PictureBox pictureBox_map;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_shag;
    }
}

