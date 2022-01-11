namespace SBB_APP
{
    partial class Stationen_Karten
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCardShare = new System.Windows.Forms.Button();
            this.btnCardKarte = new System.Windows.Forms.Button();
            this.lblCardTitel = new System.Windows.Forms.Label();
            this.lblCardDepartureTime = new System.Windows.Forms.Label();
            this.lblCardDepartureTimePlaceholder = new System.Windows.Forms.Label();
            this.lblCardDelay = new System.Windows.Forms.Label();
            this.lblCardDelayPlaceholder = new System.Windows.Forms.Label();
            this.lblCardDuration = new System.Windows.Forms.Label();
            this.lblCardDurationPlaceholder = new System.Windows.Forms.Label();
            this.lblCardDestinationTime = new System.Windows.Forms.Label();
            this.lblCardDestinationTimePlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCardShare
            // 
            this.btnCardShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardShare.Location = new System.Drawing.Point(628, 10);
            this.btnCardShare.Name = "btnCardShare";
            this.btnCardShare.Size = new System.Drawing.Size(105, 57);
            this.btnCardShare.TabIndex = 0;
            this.btnCardShare.Text = "Teilen";
            this.btnCardShare.UseVisualStyleBackColor = true;
            // 
            // btnCardKarte
            // 
            this.btnCardKarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardKarte.Location = new System.Drawing.Point(628, 73);
            this.btnCardKarte.Name = "btnCardKarte";
            this.btnCardKarte.Size = new System.Drawing.Size(105, 61);
            this.btnCardKarte.TabIndex = 1;
            this.btnCardKarte.Text = "Karte";
            this.btnCardKarte.UseVisualStyleBackColor = true;
            // 
            // lblCardTitel
            // 
            this.lblCardTitel.AutoSize = true;
            this.lblCardTitel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardTitel.Location = new System.Drawing.Point(9, 10);
            this.lblCardTitel.Name = "lblCardTitel";
            this.lblCardTitel.Size = new System.Drawing.Size(240, 25);
            this.lblCardTitel.TabIndex = 2;
            this.lblCardTitel.Text = "Startstation ->> Endstation";
            // 
            // lblCardDepartureTime
            // 
            this.lblCardDepartureTime.AutoSize = true;
            this.lblCardDepartureTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardDepartureTime.Location = new System.Drawing.Point(11, 61);
            this.lblCardDepartureTime.Name = "lblCardDepartureTime";
            this.lblCardDepartureTime.Size = new System.Drawing.Size(66, 20);
            this.lblCardDepartureTime.TabIndex = 5;
            this.lblCardDepartureTime.Text = "Abfahrt: ";
            // 
            // lblCardDepartureTimePlaceholder
            // 
            this.lblCardDepartureTimePlaceholder.AutoSize = true;
            this.lblCardDepartureTimePlaceholder.Location = new System.Drawing.Point(108, 66);
            this.lblCardDepartureTimePlaceholder.Name = "lblCardDepartureTimePlaceholder";
            this.lblCardDepartureTimePlaceholder.Size = new System.Drawing.Size(62, 15);
            this.lblCardDepartureTimePlaceholder.TabIndex = 7;
            this.lblCardDepartureTimePlaceholder.Text = "Platzhalter";
            // 
            // lblCardDelay
            // 
            this.lblCardDelay.AutoSize = true;
            this.lblCardDelay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardDelay.Location = new System.Drawing.Point(223, 95);
            this.lblCardDelay.Name = "lblCardDelay";
            this.lblCardDelay.Size = new System.Drawing.Size(86, 20);
            this.lblCardDelay.TabIndex = 9;
            this.lblCardDelay.Text = "Verspätung:";
            // 
            // lblCardDelayPlaceholder
            // 
            this.lblCardDelayPlaceholder.AutoSize = true;
            this.lblCardDelayPlaceholder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCardDelayPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCardDelayPlaceholder.Location = new System.Drawing.Point(320, 99);
            this.lblCardDelayPlaceholder.Name = "lblCardDelayPlaceholder";
            this.lblCardDelayPlaceholder.Size = new System.Drawing.Size(62, 15);
            this.lblCardDelayPlaceholder.TabIndex = 10;
            this.lblCardDelayPlaceholder.Text = "Platzhalter";
            // 
            // lblCardDuration
            // 
            this.lblCardDuration.AutoSize = true;
            this.lblCardDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardDuration.Location = new System.Drawing.Point(223, 61);
            this.lblCardDuration.Name = "lblCardDuration";
            this.lblCardDuration.Size = new System.Drawing.Size(52, 20);
            this.lblCardDuration.TabIndex = 11;
            this.lblCardDuration.Text = "Dauer:";
            // 
            // lblCardDurationPlaceholder
            // 
            this.lblCardDurationPlaceholder.AutoSize = true;
            this.lblCardDurationPlaceholder.Location = new System.Drawing.Point(320, 66);
            this.lblCardDurationPlaceholder.Name = "lblCardDurationPlaceholder";
            this.lblCardDurationPlaceholder.Size = new System.Drawing.Size(62, 15);
            this.lblCardDurationPlaceholder.TabIndex = 12;
            this.lblCardDurationPlaceholder.Text = "Platzhalter";
            // 
            // lblCardDestinationTime
            // 
            this.lblCardDestinationTime.AutoSize = true;
            this.lblCardDestinationTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardDestinationTime.Location = new System.Drawing.Point(11, 95);
            this.lblCardDestinationTime.Name = "lblCardDestinationTime";
            this.lblCardDestinationTime.Size = new System.Drawing.Size(63, 20);
            this.lblCardDestinationTime.TabIndex = 6;
            this.lblCardDestinationTime.Text = "Ankunft:";
            // 
            // lblCardDestinationTimePlaceholder
            // 
            this.lblCardDestinationTimePlaceholder.AutoSize = true;
            this.lblCardDestinationTimePlaceholder.Location = new System.Drawing.Point(108, 100);
            this.lblCardDestinationTimePlaceholder.Name = "lblCardDestinationTimePlaceholder";
            this.lblCardDestinationTimePlaceholder.Size = new System.Drawing.Size(62, 15);
            this.lblCardDestinationTimePlaceholder.TabIndex = 8;
            this.lblCardDestinationTimePlaceholder.Text = "Platzhalter";
            // 
            // Stationen_Karten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblCardDurationPlaceholder);
            this.Controls.Add(this.lblCardDuration);
            this.Controls.Add(this.lblCardDelayPlaceholder);
            this.Controls.Add(this.lblCardDelay);
            this.Controls.Add(this.lblCardDestinationTimePlaceholder);
            this.Controls.Add(this.lblCardDepartureTimePlaceholder);
            this.Controls.Add(this.lblCardDestinationTime);
            this.Controls.Add(this.lblCardDepartureTime);
            this.Controls.Add(this.lblCardTitel);
            this.Controls.Add(this.btnCardKarte);
            this.Controls.Add(this.btnCardShare);
            this.Name = "Stationen_Karten";
            this.Size = new System.Drawing.Size(826, 148);
            this.Load += new System.EventHandler(this.Stationen_Karten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCardShare;
        private Button btnCardKarte;
        private Label lblCardTitel;
        private Label lblCardDepartureTime;
        private Label lblCardDepartureTimePlaceholder;
        private Label lblCardDelay;
        private Label lblCardDelayPlaceholder;
        private Label lblCardDuration;
        private Label lblCardDurationPlaceholder;
        private Label lblCardDestinationTime;
        private Label lblCardDestinationTimePlaceholder;
    }
}
