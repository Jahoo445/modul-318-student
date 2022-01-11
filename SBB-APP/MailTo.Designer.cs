namespace SBB_APP
{
    partial class MailTo
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
            this.btnMailToSend = new System.Windows.Forms.Button();
            this.tbxMailToSendTo = new System.Windows.Forms.TextBox();
            this.rtbxBodyPart = new System.Windows.Forms.RichTextBox();
            this.tbxMailToSubject = new System.Windows.Forms.TextBox();
            this.lblMailToSubject = new System.Windows.Forms.Label();
            this.lblMailToSendTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMailToSend
            // 
            this.btnMailToSend.Location = new System.Drawing.Point(12, 12);
            this.btnMailToSend.Name = "btnMailToSend";
            this.btnMailToSend.Size = new System.Drawing.Size(103, 84);
            this.btnMailToSend.TabIndex = 0;
            this.btnMailToSend.Text = "Senden ";
            this.btnMailToSend.UseVisualStyleBackColor = true;
            this.btnMailToSend.Click += new System.EventHandler(this.btnMailToSend_Click);
            // 
            // tbxMailToSendTo
            // 
            this.tbxMailToSendTo.Location = new System.Drawing.Point(195, 27);
            this.tbxMailToSendTo.Name = "tbxMailToSendTo";
            this.tbxMailToSendTo.Size = new System.Drawing.Size(250, 23);
            this.tbxMailToSendTo.TabIndex = 1;
            // 
            // rtbxBodyPart
            // 
            this.rtbxBodyPart.Location = new System.Drawing.Point(121, 113);
            this.rtbxBodyPart.Name = "rtbxBodyPart";
            this.rtbxBodyPart.Size = new System.Drawing.Size(667, 325);
            this.rtbxBodyPart.TabIndex = 2;
            this.rtbxBodyPart.Text = "";
            // 
            // tbxMailToSubject
            // 
            this.tbxMailToSubject.Location = new System.Drawing.Point(195, 73);
            this.tbxMailToSubject.Name = "tbxMailToSubject";
            this.tbxMailToSubject.Size = new System.Drawing.Size(250, 23);
            this.tbxMailToSubject.TabIndex = 3;
            // 
            // lblMailToSubject
            // 
            this.lblMailToSubject.AutoSize = true;
            this.lblMailToSubject.Location = new System.Drawing.Point(121, 76);
            this.lblMailToSubject.Name = "lblMailToSubject";
            this.lblMailToSubject.Size = new System.Drawing.Size(52, 15);
            this.lblMailToSubject.TabIndex = 4;
            this.lblMailToSubject.Text = "Subject: ";
            // 
            // lblMailToSendTo
            // 
            this.lblMailToSendTo.AutoSize = true;
            this.lblMailToSendTo.Location = new System.Drawing.Point(121, 30);
            this.lblMailToSendTo.Name = "lblMailToSendTo";
            this.lblMailToSendTo.Size = new System.Drawing.Size(68, 15);
            this.lblMailToSendTo.TabIndex = 5;
            this.lblMailToSendTo.Text = "Senden an: ";
            // 
            // MailTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMailToSendTo);
            this.Controls.Add(this.lblMailToSubject);
            this.Controls.Add(this.tbxMailToSubject);
            this.Controls.Add(this.rtbxBodyPart);
            this.Controls.Add(this.tbxMailToSendTo);
            this.Controls.Add(this.btnMailToSend);
            this.Name = "MailTo";
            this.Text = "MailTo";
            this.Load += new System.EventHandler(this.MailTo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMailToSend;
        private TextBox tbxMailToSendTo;
        private RichTextBox rtbxBodyPart;
        private TextBox tbxMailToSubject;
        private Label lblMailToSubject;
        private Label lblMailToSendTo;
    }
}