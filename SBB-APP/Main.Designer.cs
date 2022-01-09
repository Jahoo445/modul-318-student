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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
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
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.clmStartstation = new System.Windows.Forms.ColumnHeader();
            this.clmAbfahrtsuhrzeit = new System.Windows.Forms.ColumnHeader();
            this.clmEndstation = new System.Windows.Forms.ColumnHeader();
            this.clmAnkunft = new System.Windows.Forms.ColumnHeader();
            this.clmReisezeit = new System.Windows.Forms.ColumnHeader();
            this.clmVerspätungen = new System.Windows.Forms.ColumnHeader();
            this.grbLocation.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLocation
            // 
            this.grbLocation.Controls.Add(this.lblDestinationLocation);
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.cmbDestinationLocation);
            this.grbLocation.Controls.Add(this.cmbStartLocation);
            this.grbLocation.Location = new System.Drawing.Point(12, 12);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Size = new System.Drawing.Size(369, 100);
            this.grbLocation.TabIndex = 0;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Orts Angaben";
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.AutoSize = true;
            this.lblDestinationLocation.Location = new System.Drawing.Point(6, 51);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(94, 15);
            this.lblDestinationLocation.TabIndex = 11;
            this.lblDestinationLocation.Text = "Ankunftsstation:";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(6, 22);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(67, 15);
            this.lblStartLocation.TabIndex = 10;
            this.lblStartLocation.Text = "Startstation";
            // 
            // cmbDestinationLocation
            // 
            this.cmbDestinationLocation.DropDownWidth = 333;
            this.cmbDestinationLocation.FormattingEnabled = true;
            this.cmbDestinationLocation.Location = new System.Drawing.Point(121, 51);
            this.cmbDestinationLocation.Name = "cmbDestinationLocation";
            this.cmbDestinationLocation.Size = new System.Drawing.Size(242, 23);
            this.cmbDestinationLocation.TabIndex = 2;
            this.cmbDestinationLocation.TextUpdate += new System.EventHandler(this.cmbDestinationLocation_TextUpdate);
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.DropDownWidth = 333;
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(121, 22);
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
            this.grbTime.Location = new System.Drawing.Point(12, 133);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(369, 100);
            this.grbTime.TabIndex = 1;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Zeit und Datum";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm / yyyy-MM-dd";
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
            this.chbSpecifyTime.TabIndex = 6;
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
            this.btnSearch.Location = new System.Drawing.Point(491, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 221);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Verbindungen Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStartstation,
            this.clmAbfahrtsuhrzeit,
            this.clmEndstation,
            this.clmAnkunft,
            this.clmReisezeit,
            this.clmVerspätungen});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.Location = new System.Drawing.Point(12, 267);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(904, 275);
            this.ltvConnections.TabIndex = 5;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            this.ltvConnections.SelectedIndexChanged += new System.EventHandler(this.ltvConnections_SelectedIndexChanged);
            // 
            // clmStartstation
            // 
            this.clmStartstation.Text = "Startstation";
            this.clmStartstation.Width = 150;
            // 
            // clmAbfahrtsuhrzeit
            // 
            this.clmAbfahrtsuhrzeit.Text = "Abfahrtsuhrzeit";
            this.clmAbfahrtsuhrzeit.Width = 150;
            // 
            // clmEndstation
            // 
            this.clmEndstation.Text = "Endstation";
            this.clmEndstation.Width = 150;
            // 
            // clmAnkunft
            // 
            this.clmAnkunft.Text = "Ankunft";
            this.clmAnkunft.Width = 150;
            // 
            // clmReisezeit
            // 
            this.clmReisezeit.Text = "Reisezeit";
            this.clmReisezeit.Width = 150;
            // 
            // clmVerspätungen
            // 
            this.clmVerspätungen.Text = "Verspätungen";
            this.clmVerspätungen.Width = 150;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 549);
            this.Controls.Add(this.ltvConnections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.grbLocation);
            this.Name = "Main";
            this.Text = "Form1";
            this.grbLocation.ResumeLayout(false);
            this.grbLocation.PerformLayout();
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
        private ListView ltvConnections;
        private ColumnHeader clmStartstation;
        private ColumnHeader clmAbfahrtsuhrzeit;
        private ColumnHeader clmEndstation;
        private ColumnHeader clmAnkunft;
        private ColumnHeader clmReisezeit;
        private ColumnHeader clmVerspätungen;
    }
}