namespace SBB_APP
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.rdbTakeMeHome = new System.Windows.Forms.RadioButton();
            this.rdbTimetable = new System.Windows.Forms.RadioButton();
            this.rdbFromTo = new System.Windows.Forms.RadioButton();
            this.btnPictureReverser = new System.Windows.Forms.PictureBox();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.cmbDestinationLocation = new System.Windows.Forms.ComboBox();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.chbSpecifyTime = new System.Windows.Forms.CheckBox();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.rdbDeparture = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchStations = new System.Windows.Forms.Button();
            this.flpStationResult = new System.Windows.Forms.FlowLayoutPanel();
            this.grbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureReverser)).BeginInit();
            this.grbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLocation
            // 
            this.grbLocation.Controls.Add(this.rdbTakeMeHome);
            this.grbLocation.Controls.Add(this.rdbTimetable);
            this.grbLocation.Controls.Add(this.rdbFromTo);
            this.grbLocation.Controls.Add(this.btnPictureReverser);
            this.grbLocation.Controls.Add(this.lblDestinationLocation);
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.cmbDestinationLocation);
            this.grbLocation.Controls.Add(this.cmbStartLocation);
            this.grbLocation.Location = new System.Drawing.Point(12, 95);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Size = new System.Drawing.Size(440, 138);
            this.grbLocation.TabIndex = 0;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Orts Angaben";
            this.grbLocation.Enter += new System.EventHandler(this.grbLocation_Enter);
            // 
            // rdbTakeMeHome
            // 
            this.rdbTakeMeHome.AutoSize = true;
            this.rdbTakeMeHome.Location = new System.Drawing.Point(263, 22);
            this.rdbTakeMeHome.Name = "rdbTakeMeHome";
            this.rdbTakeMeHome.Size = new System.Drawing.Size(104, 19);
            this.rdbTakeMeHome.TabIndex = 15;
            this.rdbTakeMeHome.TabStop = true;
            this.rdbTakeMeHome.Text = "Take me Home";
            this.rdbTakeMeHome.UseVisualStyleBackColor = true;
            this.rdbTakeMeHome.CheckedChanged += new System.EventHandler(this.rdbTimetable_CheckedChanged);
            // 
            // rdbTimetable
            // 
            this.rdbTimetable.AutoSize = true;
            this.rdbTimetable.Location = new System.Drawing.Point(152, 22);
            this.rdbTimetable.Name = "rdbTimetable";
            this.rdbTimetable.Size = new System.Drawing.Size(71, 19);
            this.rdbTimetable.TabIndex = 14;
            this.rdbTimetable.TabStop = true;
            this.rdbTimetable.Text = "Fahrplan";
            this.rdbTimetable.UseVisualStyleBackColor = true;
            this.rdbTimetable.CheckedChanged += new System.EventHandler(this.rdbTimetable_CheckedChanged);
            // 
            // rdbFromTo
            // 
            this.rdbFromTo.AutoSize = true;
            this.rdbFromTo.Checked = true;
            this.rdbFromTo.Location = new System.Drawing.Point(43, 22);
            this.rdbFromTo.Name = "rdbFromTo";
            this.rdbFromTo.Size = new System.Drawing.Size(78, 19);
            this.rdbFromTo.TabIndex = 13;
            this.rdbFromTo.TabStop = true;
            this.rdbFromTo.Text = "Von-Nach";
            this.rdbFromTo.UseVisualStyleBackColor = true;
            this.rdbFromTo.CheckedChanged += new System.EventHandler(this.rdbFromTo_CheckedChanged);
            // 
            // btnPictureReverser
            // 
            this.btnPictureReverser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPictureReverser.ErrorImage")));
            this.btnPictureReverser.Image = ((System.Drawing.Image)(resources.GetObject("btnPictureReverser.Image")));
            this.btnPictureReverser.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPictureReverser.InitialImage")));
            this.btnPictureReverser.Location = new System.Drawing.Point(375, 65);
            this.btnPictureReverser.Name = "btnPictureReverser";
            this.btnPictureReverser.Size = new System.Drawing.Size(60, 52);
            this.btnPictureReverser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPictureReverser.TabIndex = 12;
            this.btnPictureReverser.TabStop = false;
            this.btnPictureReverser.Click += new System.EventHandler(this.btnPictureReverser_Click);
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.AutoSize = true;
            this.lblDestinationLocation.Location = new System.Drawing.Point(12, 94);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(94, 15);
            this.lblDestinationLocation.TabIndex = 11;
            this.lblDestinationLocation.Text = "Ankunftsstation:";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(12, 65);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(70, 15);
            this.lblStartLocation.TabIndex = 10;
            this.lblStartLocation.Text = "Startstation:";
            // 
            // cmbDestinationLocation
            // 
            this.cmbDestinationLocation.DropDownWidth = 333;
            this.cmbDestinationLocation.FormattingEnabled = true;
            this.cmbDestinationLocation.Location = new System.Drawing.Point(127, 94);
            this.cmbDestinationLocation.Name = "cmbDestinationLocation";
            this.cmbDestinationLocation.Size = new System.Drawing.Size(242, 23);
            this.cmbDestinationLocation.TabIndex = 2;
            this.cmbDestinationLocation.TextUpdate += new System.EventHandler(this.cmbDestinationLocation_TextUpdate);
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.DropDownWidth = 333;
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(127, 65);
            this.cmbStartLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(242, 23);
            this.cmbStartLocation.TabIndex = 1;
            this.cmbStartLocation.TextUpdate += new System.EventHandler(this.cmbStartLocation_TextUpdate);
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.dtpTime);
            this.grbTime.Controls.Add(this.chbSpecifyTime);
            this.grbTime.Controls.Add(this.rdbArrival);
            this.grbTime.Controls.Add(this.rdbDeparture);
            this.grbTime.Location = new System.Drawing.Point(472, 133);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(369, 100);
            this.grbTime.TabIndex = 50;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Zeit und Datum";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "dd-MM-yyyy\\ HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(121, 36);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(242, 23);
            this.dtpTime.TabIndex = 4;
            // 
            // chbSpecifyTime
            // 
            this.chbSpecifyTime.AutoSize = true;
            this.chbSpecifyTime.Location = new System.Drawing.Point(6, 41);
            this.chbSpecifyTime.Name = "chbSpecifyTime";
            this.chbSpecifyTime.Size = new System.Drawing.Size(52, 19);
            this.chbSpecifyTime.TabIndex = 4;
            this.chbSpecifyTime.Text = "Zeit: ";
            this.chbSpecifyTime.UseVisualStyleBackColor = true;
            this.chbSpecifyTime.CheckedChanged += new System.EventHandler(this.chbSpecifyTime_CheckedChanged);
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(121, 75);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(68, 19);
            this.rdbArrival.TabIndex = 5;
            this.rdbArrival.Text = "Ankunft";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // rdbDeparture
            // 
            this.rdbDeparture.AutoSize = true;
            this.rdbDeparture.Checked = true;
            this.rdbDeparture.Location = new System.Drawing.Point(6, 75);
            this.rdbDeparture.Name = "rdbDeparture";
            this.rdbDeparture.Size = new System.Drawing.Size(65, 19);
            this.rdbDeparture.TabIndex = 4;
            this.rdbDeparture.TabStop = true;
            this.rdbDeparture.Text = "Abfahrt";
            this.rdbDeparture.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(440, 64);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Verbindungen Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchStations
            // 
            this.btnSearchStations.Location = new System.Drawing.Point(472, 12);
            this.btnSearchStations.Name = "btnSearchStations";
            this.btnSearchStations.Size = new System.Drawing.Size(369, 64);
            this.btnSearchStations.TabIndex = 5;
            this.btnSearchStations.Text = "Station in der nähe Suchen";
            this.btnSearchStations.UseVisualStyleBackColor = true;
            this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
            // 
            // flpStationResult
            // 
            this.flpStationResult.AutoScroll = true;
            this.flpStationResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpStationResult.Location = new System.Drawing.Point(12, 239);
            this.flpStationResult.Name = "flpStationResult";
            this.flpStationResult.Size = new System.Drawing.Size(829, 298);
            this.flpStationResult.TabIndex = 8;
            // 
            // Main
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 549);
            this.Controls.Add(this.flpStationResult);
            this.Controls.Add(this.btnSearchStations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.grbLocation);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Enter += new System.EventHandler(this.btnSearch_Click);
            this.grbLocation.ResumeLayout(false);
            this.grbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureReverser)).EndInit();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbLocation;
        private Label lblDestinationLocation;
        private Label lblStartLocation;
        private ComboBox cmbDestinationLocation;
        private ComboBox cmbStartLocation;
        private GroupBox grbTime;
        private DateTimePicker dtpTime;
        private CheckBox chbSpecifyTime;
        private RadioButton rdbArrival;
        private RadioButton rdbDeparture;
        private Button btnSearch;
        private Button btnSearchStations;
        private FlowLayoutPanel flpStationResult;
        private PictureBox btnPictureReverser;
        private RadioButton rdbTimetable;
        private RadioButton rdbFromTo;
        private RadioButton rdbTakeMeHome;
    }
}