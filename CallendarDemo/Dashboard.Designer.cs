namespace CallendarDemo
{
    partial class Dashboard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.Label1 = new System.Windows.Forms.Label();
            this.EventNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericHour = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CityButton = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WeatherImage = new System.Windows.Forms.PictureBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EventsListBox
            // 
            this.EventsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 18;
            this.EventsListBox.Location = new System.Drawing.Point(355, 181);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EventsListBox.Size = new System.Drawing.Size(271, 202);
            this.EventsListBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(117, 192);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(18, 18);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(24, 264);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Add Event";
            // 
            // EventNameText
            // 
            this.EventNameText.Location = new System.Drawing.Point(64, 296);
            this.EventNameText.Name = "EventNameText";
            this.EventNameText.Size = new System.Drawing.Size(223, 22);
            this.EventNameText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // numericHour
            // 
            this.numericHour.Location = new System.Drawing.Point(64, 322);
            this.numericHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericHour.Name = "numericHour";
            this.numericHour.Size = new System.Drawing.Size(38, 22);
            this.numericHour.TabIndex = 8;
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(126, 322);
            this.numericMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(38, 22);
            this.numericMin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "min";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(117, 360);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CityButton
            // 
            this.CityButton.Location = new System.Drawing.Point(548, 125);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(76, 23);
            this.CityButton.TabIndex = 14;
            this.CityButton.Text = "Change city";
            this.CityButton.UseVisualStyleBackColor = true;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(385, 128);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(157, 22);
            this.CityTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "City";
            // 
            // WeatherImage
            // 
            this.WeatherImage.Location = new System.Drawing.Point(370, 27);
            this.WeatherImage.Name = "WeatherImage";
            this.WeatherImage.Size = new System.Drawing.Size(99, 93);
            this.WeatherImage.TabIndex = 17;
            this.WeatherImage.TabStop = false;
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeatherLabel.Location = new System.Drawing.Point(313, 18);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(0, 18);
            this.WeatherLabel.TabIndex = 18;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeLabel.Location = new System.Drawing.Point(492, 41);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(99, 81);
            this.DegreeLabel.TabIndex = 19;
            this.DegreeLabel.Text = "23";
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 397);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.WeatherImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericMin);
            this.Controls.Add(this.numericHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EventNameText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EventsListBox);
            this.Name = "Dashboard";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox EventNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericHour;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CityButton;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox WeatherImage;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label DegreeLabel;
    }
}

