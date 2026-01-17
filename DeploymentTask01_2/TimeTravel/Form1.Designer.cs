namespace TimeTravel
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
            this.ImageBush = new System.Windows.Forms.PictureBox();
            this.GroupSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSqMax = new System.Windows.Forms.Label();
            this.LabelSqMid = new System.Windows.Forms.Label();
            this.LabelSqMin = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.CheckAssumeForm = new System.Windows.Forms.CheckBox();
            this.CheckDeterministic = new System.Windows.Forms.CheckBox();
            this.Sqwimble = new System.Windows.Forms.TrackBar();
            this.LocationLong = new System.Windows.Forms.TextBox();
            this.LocationLat = new System.Windows.Forms.TextBox();
            this.DateYConf = new System.Windows.Forms.ComboBox();
            this.DateY = new System.Windows.Forms.NumericUpDown();
            this.DateM = new System.Windows.Forms.NumericUpDown();
            this.DateD = new System.Windows.Forms.NumericUpDown();
            this.LabelSqwimble = new System.Windows.Forms.Label();
            this.LabelLocationLong = new System.Windows.Forms.Label();
            this.LabelLocationLat = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelM = new System.Windows.Forms.Label();
            this.LabelD = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBush)).BeginInit();
            this.GroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sqwimble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateD)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBush
            // 
            this.ImageBush.BackgroundImage = global::TimeTravel.Properties.Resources.George_W_Bush;
            this.ImageBush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBush.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImageBush.Location = new System.Drawing.Point(8, 8);
            this.ImageBush.Name = "ImageBush";
            this.ImageBush.Size = new System.Drawing.Size(360, 477);
            this.ImageBush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBush.TabIndex = 0;
            this.ImageBush.TabStop = false;
            // 
            // GroupSettings
            // 
            this.GroupSettings.Controls.Add(this.label1);
            this.GroupSettings.Controls.Add(this.LabelSqMax);
            this.GroupSettings.Controls.Add(this.LabelSqMid);
            this.GroupSettings.Controls.Add(this.LabelSqMin);
            this.GroupSettings.Controls.Add(this.ButtonStart);
            this.GroupSettings.Controls.Add(this.CheckAssumeForm);
            this.GroupSettings.Controls.Add(this.CheckDeterministic);
            this.GroupSettings.Controls.Add(this.Sqwimble);
            this.GroupSettings.Controls.Add(this.LocationLong);
            this.GroupSettings.Controls.Add(this.LocationLat);
            this.GroupSettings.Controls.Add(this.DateYConf);
            this.GroupSettings.Controls.Add(this.DateY);
            this.GroupSettings.Controls.Add(this.DateM);
            this.GroupSettings.Controls.Add(this.DateD);
            this.GroupSettings.Controls.Add(this.LabelSqwimble);
            this.GroupSettings.Controls.Add(this.LabelLocationLong);
            this.GroupSettings.Controls.Add(this.LabelLocationLat);
            this.GroupSettings.Controls.Add(this.LabelLocation);
            this.GroupSettings.Controls.Add(this.LabelY);
            this.GroupSettings.Controls.Add(this.LabelM);
            this.GroupSettings.Controls.Add(this.LabelD);
            this.GroupSettings.Controls.Add(this.LabelDate);
            this.GroupSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupSettings.Location = new System.Drawing.Point(374, 8);
            this.GroupSettings.Name = "GroupSettings";
            this.GroupSettings.Size = new System.Drawing.Size(560, 477);
            this.GroupSettings.TabIndex = 5;
            this.GroupSettings.TabStop = false;
            this.GroupSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(147, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Currently hidden text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // LabelSqMax
            // 
            this.LabelSqMax.AutoSize = true;
            this.LabelSqMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelSqMax.Location = new System.Drawing.Point(311, 262);
            this.LabelSqMax.Name = "LabelSqMax";
            this.LabelSqMax.Size = new System.Drawing.Size(32, 17);
            this.LabelSqMax.TabIndex = 19;
            this.LabelSqMax.Text = "100";
            this.LabelSqMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSqMid
            // 
            this.LabelSqMid.AutoSize = true;
            this.LabelSqMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelSqMid.Location = new System.Drawing.Point(228, 262);
            this.LabelSqMid.Name = "LabelSqMid";
            this.LabelSqMid.Size = new System.Drawing.Size(16, 17);
            this.LabelSqMid.TabIndex = 20;
            this.LabelSqMid.Text = "0";
            this.LabelSqMid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelSqMin
            // 
            this.LabelSqMin.AutoSize = true;
            this.LabelSqMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelSqMin.Location = new System.Drawing.Point(128, 262);
            this.LabelSqMin.Name = "LabelSqMin";
            this.LabelSqMin.Size = new System.Drawing.Size(37, 17);
            this.LabelSqMin.TabIndex = 18;
            this.LabelSqMin.Text = "-100";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonStart.Location = new System.Drawing.Point(18, 391);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(105, 53);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // CheckAssumeForm
            // 
            this.CheckAssumeForm.AutoSize = true;
            this.CheckAssumeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckAssumeForm.Location = new System.Drawing.Point(18, 349);
            this.CheckAssumeForm.Name = "CheckAssumeForm";
            this.CheckAssumeForm.Size = new System.Drawing.Size(136, 24);
            this.CheckAssumeForm.TabIndex = 2;
            this.CheckAssumeForm.Text = "Assume Form";
            this.CheckAssumeForm.UseVisualStyleBackColor = true;
            this.CheckAssumeForm.CheckedChanged += new System.EventHandler(this.CheckAssumeForm_CheckedChanged);
            // 
            // CheckDeterministic
            // 
            this.CheckDeterministic.AutoSize = true;
            this.CheckDeterministic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckDeterministic.Location = new System.Drawing.Point(18, 318);
            this.CheckDeterministic.Name = "CheckDeterministic";
            this.CheckDeterministic.Size = new System.Drawing.Size(131, 24);
            this.CheckDeterministic.TabIndex = 2;
            this.CheckDeterministic.Text = "Deterministic";
            this.CheckDeterministic.UseVisualStyleBackColor = true;
            this.CheckDeterministic.CheckedChanged += new System.EventHandler(this.CheckDeterministic_CheckedChanged);
            // 
            // Sqwimble
            // 
            this.Sqwimble.LargeChange = 10;
            this.Sqwimble.Location = new System.Drawing.Point(130, 221);
            this.Sqwimble.Maximum = 100;
            this.Sqwimble.Minimum = -100;
            this.Sqwimble.Name = "Sqwimble";
            this.Sqwimble.Size = new System.Drawing.Size(213, 56);
            this.Sqwimble.SmallChange = 5;
            this.Sqwimble.TabIndex = 16;
            this.Sqwimble.TickFrequency = 5;
            this.Sqwimble.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Sqwimble.Scroll += new System.EventHandler(this.Sqwimble_Scroll);
            // 
            // LocationLong
            // 
            this.LocationLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LocationLong.Location = new System.Drawing.Point(192, 165);
            this.LocationLong.Name = "LocationLong";
            this.LocationLong.Size = new System.Drawing.Size(194, 26);
            this.LocationLong.TabIndex = 14;
            this.LocationLong.TextChanged += new System.EventHandler(this.LocationLong_TextChanged);
            // 
            // LocationLat
            // 
            this.LocationLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LocationLat.Location = new System.Drawing.Point(192, 117);
            this.LocationLat.Name = "LocationLat";
            this.LocationLat.Size = new System.Drawing.Size(194, 26);
            this.LocationLat.TabIndex = 13;
            this.LocationLat.TextChanged += new System.EventHandler(this.LocationLat_TextChanged);
            // 
            // DateYConf
            // 
            this.DateYConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateYConf.FormattingEnabled = true;
            this.DateYConf.Items.AddRange(new object[] {
            "CE",
            "BCE"});
            this.DateYConf.Location = new System.Drawing.Point(316, 55);
            this.DateYConf.Name = "DateYConf";
            this.DateYConf.Size = new System.Drawing.Size(70, 28);
            this.DateYConf.TabIndex = 15;
            this.DateYConf.Text = "CE";
            // 
            // DateY
            // 
            this.DateY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateY.Location = new System.Drawing.Point(241, 57);
            this.DateY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DateY.Name = "DateY";
            this.DateY.Size = new System.Drawing.Size(70, 26);
            this.DateY.TabIndex = 5;
            this.DateY.ValueChanged += new System.EventHandler(this.DateY_ValueChanged);
            // 
            // DateM
            // 
            this.DateM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateM.Location = new System.Drawing.Point(172, 57);
            this.DateM.Name = "DateM";
            this.DateM.Size = new System.Drawing.Size(46, 26);
            this.DateM.TabIndex = 4;
            this.DateM.ValueChanged += new System.EventHandler(this.DateM_ValueChanged);
            // 
            // DateD
            // 
            this.DateD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateD.Location = new System.Drawing.Point(101, 57);
            this.DateD.Name = "DateD";
            this.DateD.Size = new System.Drawing.Size(46, 26);
            this.DateD.TabIndex = 3;
            this.DateD.ValueChanged += new System.EventHandler(this.DateD_ValueChanged);
            // 
            // LabelSqwimble
            // 
            this.LabelSqwimble.AutoSize = true;
            this.LabelSqwimble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelSqwimble.Location = new System.Drawing.Point(18, 221);
            this.LabelSqwimble.Name = "LabelSqwimble";
            this.LabelSqwimble.Size = new System.Drawing.Size(97, 25);
            this.LabelSqwimble.TabIndex = 17;
            this.LabelSqwimble.Text = "Sqwimble";
            // 
            // LabelLocationLong
            // 
            this.LabelLocationLong.AutoSize = true;
            this.LabelLocationLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelLocationLong.Location = new System.Drawing.Point(126, 164);
            this.LabelLocationLong.Name = "LabelLocationLong";
            this.LabelLocationLong.Size = new System.Drawing.Size(61, 25);
            this.LabelLocationLong.TabIndex = 12;
            this.LabelLocationLong.Text = "Long.";
            // 
            // LabelLocationLat
            // 
            this.LabelLocationLat.AutoSize = true;
            this.LabelLocationLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelLocationLat.Location = new System.Drawing.Point(126, 118);
            this.LabelLocationLat.Name = "LabelLocationLat";
            this.LabelLocationLat.Size = new System.Drawing.Size(44, 25);
            this.LabelLocationLat.TabIndex = 11;
            this.LabelLocationLat.Text = "Lat.";
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelLocation.Location = new System.Drawing.Point(18, 118);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(86, 25);
            this.LabelLocation.TabIndex = 10;
            this.LabelLocation.Text = "Location";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelY.Location = new System.Drawing.Point(219, 58);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(25, 25);
            this.LabelY.TabIndex = 9;
            this.LabelY.Text = "Y";
            // 
            // LabelM
            // 
            this.LabelM.AutoSize = true;
            this.LabelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelM.Location = new System.Drawing.Point(147, 58);
            this.LabelM.Name = "LabelM";
            this.LabelM.Size = new System.Drawing.Size(29, 25);
            this.LabelM.TabIndex = 8;
            this.LabelM.Text = "M";
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelD.Location = new System.Drawing.Point(78, 58);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(26, 25);
            this.LabelD.TabIndex = 7;
            this.LabelD.Text = "D";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelDate.Location = new System.Drawing.Point(18, 58);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(53, 25);
            this.LabelDate.TabIndex = 6;
            this.LabelDate.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.ImageBush);
            this.Controls.Add(this.GroupSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Time Travel (r/ThomasThePlankEngine)";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBush)).EndInit();
            this.GroupSettings.ResumeLayout(false);
            this.GroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sqwimble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateD)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox ImageBush;
		private System.Windows.Forms.GroupBox GroupSettings;
		private System.Windows.Forms.Label LabelDate;
		private System.Windows.Forms.Label LabelD;
		private System.Windows.Forms.Label LabelM;
		private System.Windows.Forms.Label LabelY;
		private System.Windows.Forms.Label LabelLocation;
		private System.Windows.Forms.Label LabelLocationLat;
		private System.Windows.Forms.Label LabelLocationLong;
		private System.Windows.Forms.Label LabelSqwimble;
		private System.Windows.Forms.NumericUpDown DateD;
		private System.Windows.Forms.NumericUpDown DateM;
		private System.Windows.Forms.NumericUpDown DateY;
		private System.Windows.Forms.ComboBox DateYConf;
		private System.Windows.Forms.TextBox LocationLong;
		private System.Windows.Forms.TextBox LocationLat;
		private System.Windows.Forms.TrackBar Sqwimble;
		private System.Windows.Forms.CheckBox CheckDeterministic;
		private System.Windows.Forms.CheckBox CheckAssumeForm;
		private System.Windows.Forms.Button ButtonStart;
		private System.Windows.Forms.Label LabelSqMin;
		private System.Windows.Forms.Label LabelSqMax;
		private System.Windows.Forms.Label LabelSqMid;
		private System.Windows.Forms.Label label1;
	}
}
