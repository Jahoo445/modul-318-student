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

namespace SBB_APP
{
    public partial class MailTo : Form
    {

        public MailTo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMailToSend_Click(object sender, EventArgs e)
        {

        }
        //private void GetConnectionswithCardss(StationBoard connection, Station station)
        //{
        //    Connections _connections = _transportHandler.GetConnections(cmbStartLocation.Text, cmbDestinationLocation.Text, lala, trainTime, trainTime);
        //    Connections _connections = _transportHandler.GetConnections(cmbStartLocation.Text, Convert.ToString(connection.To), lala, trainTime, trainTime);
        //    try
        //    {
        //        TimeSpan? Fahrdauer;
        //        var stationenKarten = new Stationen_Karten();
        //        flpStationResult.Controls.Add(stationenKarten);
        //        stationenKarten.Width = 829;
        //        stationenKarten.Height = 150;
        //        stationenKarten.Titel = Convert.ToString(station.Name) + " --> " + Convert.ToString(connection.To);
        //        stationenKarten.Info1Bez = "Abfahrtzeit: ";
        //        stationenKarten.Info1 = connection.Stop.Departure.ToString("dd.mm.yyyy hh:mm");
        //        stationenKarten.Info2Bez = "ankunftszeit: ";
        //        stationenKarten.Info2 = connection.to.arrival.value.tostring("dd.mm.yyyy hh:mm");

        //        stationenKarten.info3bez = "fahrtdauer: ";
        //        Fahrdauer = connection.to.arrival - connection.from.departure;
        //        if (fahrdauer.hasvalue)
        //        {
        //            stationenkarten.info3 = fahrdauer.value.tostring(@"hh\:mm");
        //        }
        //        if (connection.to.delay > 0 || connection.to.delay != null)
        //        {
        //            stationenkarten.verspaetung1 = "+ " + convert.tostring(connection.to.delay);
        //        }
        //        else
        //        {
        //            stationenkarten.verspaetung1 = "";
        //            stationenkarten.verspaetungbez = "";
        //        }
        //        i++;
        //        if (i == 10) { break; }

        //    }
        //    catch
        //    {
        //        System.Windows.Forms.MessageBox.Show("Keine Ergebnisse gefunden.");
        //    }

        //}
    }
}
