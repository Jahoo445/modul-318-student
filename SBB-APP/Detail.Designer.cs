
namespace SBB
{
    partial class Detail
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
            this.DetailGroup = new System.Windows.Forms.GroupBox();
            this.lblDestinationTimePlaceholder = new System.Windows.Forms.Label();
            this.lblDepartureTimePlaceholder = new System.Windows.Forms.Label();
            this.lblDestinationStationPlaceholder = new System.Windows.Forms.Label();
            this.lblDepartureStationPlaceholder = new System.Windows.Forms.Label();
            this.lblDestinationTime = new System.Windows.Forms.Label();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.arrivalTime = new System.Windows.Forms.ColumnHeader();
            this.stationName = new System.Windows.Forms.ColumnHeader();
            this.departure_time = new System.Windows.Forms.ColumnHeader();
            this.DetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailGroup
            // 
            this.DetailGroup.Controls.Add(this.lblDestinationTimePlaceholder);
            this.DetailGroup.Controls.Add(this.lblDepartureTimePlaceholder);
            this.DetailGroup.Controls.Add(this.lblDestinationStationPlaceholder);
            this.DetailGroup.Controls.Add(this.lblDepartureStationPlaceholder);
            this.DetailGroup.Controls.Add(this.lblDestinationTime);
            this.DetailGroup.Controls.Add(this.lblDestinationStation);
            this.DetailGroup.Controls.Add(this.lblDepartureTime);
            this.DetailGroup.Controls.Add(this.lblDepartureStation);
            this.DetailGroup.Location = new System.Drawing.Point(13, 12);
            this.DetailGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailGroup.Name = "DetailGroup";
            this.DetailGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailGroup.Size = new System.Drawing.Size(490, 594);
            this.DetailGroup.TabIndex = 0;
            this.DetailGroup.TabStop = false;
            this.DetailGroup.Text = "Details";
            // 
            // lblDestinationTimePlaceholder
            // 
            this.lblDestinationTimePlaceholder.AutoSize = true;
            this.lblDestinationTimePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationTimePlaceholder.ForeColor = System.Drawing.Color.Blue;
            this.lblDestinationTimePlaceholder.Location = new System.Drawing.Point(233, 523);
            this.lblDestinationTimePlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationTimePlaceholder.Name = "lblDestinationTimePlaceholder";
            this.lblDestinationTimePlaceholder.Size = new System.Drawing.Size(95, 16);
            this.lblDestinationTimePlaceholder.TabIndex = 17;
            this.lblDestinationTimePlaceholder.Text = "placerholder";
            // 
            // lblDepartureTimePlaceholder
            // 
            this.lblDepartureTimePlaceholder.AutoSize = true;
            this.lblDepartureTimePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTimePlaceholder.ForeColor = System.Drawing.Color.Blue;
            this.lblDepartureTimePlaceholder.Location = new System.Drawing.Point(233, 384);
            this.lblDepartureTimePlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureTimePlaceholder.Name = "lblDepartureTimePlaceholder";
            this.lblDepartureTimePlaceholder.Size = new System.Drawing.Size(95, 16);
            this.lblDepartureTimePlaceholder.TabIndex = 16;
            this.lblDepartureTimePlaceholder.Text = "placerholder";
            // 
            // lblDestinationStationPlaceholder
            // 
            this.lblDestinationStationPlaceholder.AutoSize = true;
            this.lblDestinationStationPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationStationPlaceholder.ForeColor = System.Drawing.Color.Blue;
            this.lblDestinationStationPlaceholder.Location = new System.Drawing.Point(239, 232);
            this.lblDestinationStationPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationStationPlaceholder.Name = "lblDestinationStationPlaceholder";
            this.lblDestinationStationPlaceholder.Size = new System.Drawing.Size(90, 16);
            this.lblDestinationStationPlaceholder.TabIndex = 15;
            this.lblDestinationStationPlaceholder.Text = "placeholder";
            // 
            // lblDepartureStationPlaceholder
            // 
            this.lblDepartureStationPlaceholder.AutoSize = true;
            this.lblDepartureStationPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureStationPlaceholder.ForeColor = System.Drawing.Color.Blue;
            this.lblDepartureStationPlaceholder.Location = new System.Drawing.Point(239, 85);
            this.lblDepartureStationPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureStationPlaceholder.Name = "lblDepartureStationPlaceholder";
            this.lblDepartureStationPlaceholder.Size = new System.Drawing.Size(90, 16);
            this.lblDepartureStationPlaceholder.TabIndex = 14;
            this.lblDepartureStationPlaceholder.Text = "placeholder";
            // 
            // lblDestinationTime
            // 
            this.lblDestinationTime.AutoSize = true;
            this.lblDestinationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationTime.Location = new System.Drawing.Point(28, 516);
            this.lblDestinationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationTime.Name = "lblDestinationTime";
            this.lblDestinationTime.Size = new System.Drawing.Size(85, 25);
            this.lblDestinationTime.TabIndex = 3;
            this.lblDestinationTime.Text = "Ankunft:";
            // 
            // lblDestinationStation
            // 
            this.lblDestinationStation.AutoSize = true;
            this.lblDestinationStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationStation.Location = new System.Drawing.Point(28, 224);
            this.lblDestinationStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationStation.Name = "lblDestinationStation";
            this.lblDestinationStation.Size = new System.Drawing.Size(110, 25);
            this.lblDestinationStation.TabIndex = 2;
            this.lblDestinationStation.Text = "Endstation:";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTime.Location = new System.Drawing.Point(28, 376);
            this.lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(81, 25);
            this.lblDepartureTime.TabIndex = 1;
            this.lblDepartureTime.Text = "Abfahrt:";
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureStation.Location = new System.Drawing.Point(28, 76);
            this.lblDepartureStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(116, 25);
            this.lblDepartureStation.TabIndex = 0;
            this.lblDepartureStation.Text = "Startstation:";
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.arrivalTime,
            this.stationName,
            this.departure_time});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.Location = new System.Drawing.Point(558, 12);
            this.ltvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(525, 594);
            this.ltvConnections.TabIndex = 13;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Text = "Arrival Time";
            this.arrivalTime.Width = 173;
            // 
            // stationName
            // 
            this.stationName.Text = "station name";
            this.stationName.Width = 173;
            // 
            // departure_time
            // 
            this.departure_time.Text = "departure_time";
            this.departure_time.Width = 173;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 618);
            this.Controls.Add(this.ltvConnections);
            this.Controls.Add(this.DetailGroup);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Detail";
            this.Text = "Detail View";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.DetailGroup.ResumeLayout(false);
            this.DetailGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DetailGroup;
        private System.Windows.Forms.Label lblDestinationTime;
        private System.Windows.Forms.Label lblDestinationStation;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartureStation;
        private System.Windows.Forms.ListView ltvConnections;
        private System.Windows.Forms.ColumnHeader arrivalTime;
        private System.Windows.Forms.ColumnHeader stationName;
        private System.Windows.Forms.ColumnHeader departure_time;
        private System.Windows.Forms.Label lblDestinationTimePlaceholder;
        private System.Windows.Forms.Label lblDepartureTimePlaceholder;
        private System.Windows.Forms.Label lblDestinationStationPlaceholder;
        private System.Windows.Forms.Label lblDepartureStationPlaceholder;
    }
}