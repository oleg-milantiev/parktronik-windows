namespace moParctronic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yaw = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pitch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.parkGapSlider = new System.Windows.Forms.TrackBar();
            this.parkData = new System.Windows.Forms.TextBox();
            this.parkPanel = new System.Windows.Forms.Panel();
            this.parkButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkGapSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM-порт";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(73, 13);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(73, 21);
            this.comboBoxComPort.TabIndex = 1;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(150, 10);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(65, 25);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные датчиков";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.temp);
            this.groupBox4.Location = new System.Drawing.Point(95, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(95, 80);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Температура";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "°С";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(5, 19);
            this.temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(27, 13);
            this.temp.TabIndex = 1;
            this.temp.Text = "N/A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yaw);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pitch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.roll);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(86, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Повороты";
            // 
            // yaw
            // 
            this.yaw.AutoSize = true;
            this.yaw.Location = new System.Drawing.Point(45, 58);
            this.yaw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yaw.Name = "yaw";
            this.yaw.Size = new System.Drawing.Size(27, 13);
            this.yaw.TabIndex = 5;
            this.yaw.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yaw";
            // 
            // pitch
            // 
            this.pitch.AutoSize = true;
            this.pitch.Location = new System.Drawing.Point(45, 37);
            this.pitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(27, 13);
            this.pitch.TabIndex = 3;
            this.pitch.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pitch";
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.Location = new System.Drawing.Point(45, 18);
            this.roll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(27, 13);
            this.roll.TabIndex = 1;
            this.roll.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Roll";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.parkGapSlider);
            this.groupBox5.Controls.Add(this.parkData);
            this.groupBox5.Controls.Add(this.parkPanel);
            this.groupBox5.Controls.Add(this.parkButton);
            this.groupBox5.Location = new System.Drawing.Point(5, 47);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(206, 191);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Парковка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileName);
            this.groupBox3.Controls.Add(this.fileButton);
            this.groupBox3.Location = new System.Drawing.Point(11, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 42);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Файл";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(3, 14);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 2;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(117, 13);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(63, 23);
            this.fileButton.TabIndex = 1;
            this.fileButton.Text = "Выбрать";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // parkGapSlider
            // 
            this.parkGapSlider.Location = new System.Drawing.Point(8, 61);
            this.parkGapSlider.Margin = new System.Windows.Forms.Padding(2);
            this.parkGapSlider.Minimum = 1;
            this.parkGapSlider.Name = "parkGapSlider";
            this.parkGapSlider.Size = new System.Drawing.Size(182, 42);
            this.parkGapSlider.TabIndex = 3;
            this.parkGapSlider.Value = 1;
            this.parkGapSlider.Scroll += new System.EventHandler(this.parkGapSlider_Scroll);
            // 
            // parkData
            // 
            this.parkData.Enabled = false;
            this.parkData.Location = new System.Drawing.Point(85, 18);
            this.parkData.Margin = new System.Windows.Forms.Padding(2);
            this.parkData.Multiline = true;
            this.parkData.Name = "parkData";
            this.parkData.Size = new System.Drawing.Size(105, 39);
            this.parkData.TabIndex = 2;
            // 
            // parkPanel
            // 
            this.parkPanel.BackColor = System.Drawing.Color.Red;
            this.parkPanel.Location = new System.Drawing.Point(8, 103);
            this.parkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.parkPanel.Name = "parkPanel";
            this.parkPanel.Size = new System.Drawing.Size(182, 33);
            this.parkPanel.TabIndex = 1;
            // 
            // parkButton
            // 
            this.parkButton.Location = new System.Drawing.Point(8, 17);
            this.parkButton.Margin = new System.Windows.Forms.Padding(2);
            this.parkButton.Name = "parkButton";
            this.parkButton.Size = new System.Drawing.Size(72, 39);
            this.parkButton.TabIndex = 0;
            this.parkButton.Text = "Сохранить позицию";
            this.parkButton.UseVisualStyleBackColor = true;
            this.parkButton.Click += new System.EventHandler(this.parkButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "moПарктроник";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 363);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "moParktronic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkGapSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label yaw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox parkData;
        private System.Windows.Forms.Panel parkPanel;
        private System.Windows.Forms.Button parkButton;
        private System.Windows.Forms.TrackBar parkGapSlider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

