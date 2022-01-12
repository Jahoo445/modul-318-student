using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Threading;
using SwissTransport.Models;

namespace SBB_APP
{
    public partial class MailTo : Form
    {
        public MailTo()
        {
            InitializeComponent();
        }

        public Connection toMailConnection { get; internal set; }

        private void btnMailToSend_Click(object sender, EventArgs e)
        {
            try
            {
                
                string addMail = tbxMailToSendTo.Text;
                string subject = tbxMailToSubject.Text;
                string body = rtbxBodyPart.Text;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("jahoo445.f2p@gmail.com");
                mail.To.Add(addMail);
                mail.Subject = subject;
                mail.Body = body + GetInformations();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("jahoo445.f2p@gmail.com", "Janis4007");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");


                tbxMailToSendTo.Text = "";
                tbxMailToSubject.Text = "";
                rtbxBodyPart.Text = "";

                this.Close();
            }
            catch
            {
                if (tbxMailToSendTo.Text == "")
                {
                    MessageBox.Show("Geben Sie eine E-Mailadresse ein: ");
                }
                else if (tbxMailToSubject.Text == "")
                {
                    MessageBox.Show("Geben Sie ein Betreff ein: ");
                }
            }
        }

        private string GetInformations()
        {
            string infos;
            TimeSpan? duration;
            string efektivduration = "";
            string departureTime = "";
            string arrivalTime = "";
            string delay = "";

            string titel = Convert.ToString(toMailConnection.From.Station.Name) + " --> " + Convert.ToString(toMailConnection.To.Station.Name);
            if (toMailConnection.From.Departure.HasValue)
            {
                departureTime = "Abfahrt: \t" + toMailConnection.From.Departure.Value.ToString("dd.MM.yyyy HH:mm");
            }
            if (toMailConnection.To.Arrival.HasValue)
            {
                arrivalTime = "Ankunft: \t" + toMailConnection.To.Arrival.Value.ToString("dd.MM.yyyy HH: mm");
            }
            
            duration = toMailConnection.To.Arrival - toMailConnection.From.Departure;
            
            if (duration.HasValue)
            {
                efektivduration = "Länge: \t" + duration.Value.ToString(@"hh\:mm");
            }

            if (toMailConnection.From.Delay>0)
            {
                delay = "Verspätung: \t"+"+ " + Convert.ToString(toMailConnection.From.Delay) + " Min";
            }

            infos = "\n\n\n"+ titel + "\n" + departureTime + "\n" + arrivalTime + "\n" + efektivduration + "\n" + delay;

            return infos;

        }

        private void MailTo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ist noch nicht Funktionsfähig");
        }

        private void rtbxBodyPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.KeyCode == Keys.Control)
            {
                btnMailToSend_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
