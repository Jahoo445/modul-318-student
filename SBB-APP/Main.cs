using SwissTransport.Core;
using SwissTransport.Models;

namespace SBB_APP
{
    public partial class Main : Form
    {
        private readonly Transport _transportHandler;
        public Main()
        {
            _transportHandler = new Transport();
            InitializeComponent();
            ButtonsCheckEnabled();
        }

        private void ButtonsCheckEnabled()
        {
            if (chbSpecifyTime.Checked)
            {
                dtpTime.Enabled = true;
                rdbArrival.Enabled = true;
                rdbDeparture.Enabled = true;
            }
            else
            {
                dtpTime.Enabled = false;
                rdbArrival.Enabled = false;
                rdbDeparture.Enabled = false;
            }
        }

        private void GetConnectionswithCards(Connection connection)
        {
            try
            {
                TimeSpan? Fahrdauer;
                var stationenKarten = new Stationen_Karten();
                flpStationResult.Controls.Add(stationenKarten);
                stationenKarten.Width = 829;
                stationenKarten.Height = 150;
                stationenKarten.connection = connection;
                stationenKarten.Titel = Convert.ToString(connection.From.Station.Name) + " --> " + Convert.ToString(connection.To.Station.Name);
                stationenKarten.Info1Bez = "Abfahrtzeit: ";
                if (connection.From.Departure.HasValue)
                {
                    stationenKarten.Info1 = connection.From.Departure.Value.ToString("dd.MM.yyyy HH:mm");
                }
                stationenKarten.Info2Bez = "Ankunftszeit: ";
                if (connection.To.Arrival.HasValue)
                {
                    stationenKarten.Info2 = connection.To.Arrival.Value.ToString("dd.MM.yyyy HH:mm");
                }
                stationenKarten.Info3Bez = "Fahrtdauer: ";
                Fahrdauer = connection.To.Arrival - connection.From.Departure;
                if (Fahrdauer.HasValue)
                {
                    stationenKarten.Info3 = Fahrdauer.Value.ToString(@"hh\:mm");
                }
                if (connection.From.Delay > 0)
                {
                    stationenKarten.Verspaetung1 = "+ " + Convert.ToString(connection.From.Delay) + " Min";
                    stationenKarten.VerspaetungBez = "Verspätung";
                }
                else
                {
                    stationenKarten.Verspaetung1 = "";
                    stationenKarten.VerspaetungBez = "";
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Keine Ergebnisse gefunden.");
            }
        }

        private void GetStationRecomendations(ComboBox ComboBoxElement)
        {
            try
            {
                Stations _stations = _transportHandler.GetStations(ComboBoxElement.Text);

                ComboBoxElement.Items.Clear();

                if (_stations.StationList.Count == 0)
                {
                    Console.WriteLine("Station count is 0");
                    return;
                }

                foreach (Station station in _stations.StationList)
                {
                    if (string.IsNullOrEmpty(station.Name))
                    {
                        continue;
                    }

                    ComboBoxElement.Items.Add(station.Name);
                }
            }
            catch
            {
                return;
            }
        }

        private void GetStations()
        {
            int indexDepOrAri;
            DateTime trainTime;

            if (chbSpecifyTime.Checked)
            {
                if (rdbDeparture.Checked)
                {
                    indexDepOrAri = 0;
                }
                else
                {
                    indexDepOrAri = 1;
                }
                trainTime = dtpTime.Value;
            }
            else
            {
                indexDepOrAri = 0;
                trainTime = DateTime.Now;
            }
            Connections _connections = _transportHandler.GetConnections(cmbStartLocation.Text, cmbDestinationLocation.Text, indexDepOrAri, trainTime, trainTime);



            foreach (Connection connection in _connections.ConnectionList)
            {
                GetConnectionswithCards(connection);
            }
        }

        private void GetPossibleStinations()
        {
            try
            {
                Station station = _transportHandler.GetStations(cmbStartLocation.Text).StationList.ElementAt(0);

                StationBoardRoot Board = _transportHandler.GetStationBoard(station.Name);

                Cursor.Current = Cursors.WaitCursor;

                int indexDepOrAri;
                DateTime trainTime;

                if (chbSpecifyTime.Checked)
                {
                    if (rdbDeparture.Checked)
                    {
                        indexDepOrAri = 0;
                    }
                    else
                    {
                        indexDepOrAri = 1;
                    }
                    trainTime = dtpTime.Value;
                }
                else
                {
                    indexDepOrAri = 0;
                    trainTime = DateTime.Now;
                }

                int CounterCards = 0;
                foreach (StationBoard bord in Board.Entries)
                {
                    try
                    {

                        Connections _connections = _transportHandler.GetConnections(station.Name, bord.To, indexDepOrAri, trainTime, trainTime);
                        foreach (Connection connection in _connections.ConnectionList)
                        {
                            int i = 0;
                            GetConnectionswithCards(connection);
                            i++;
                            if (i == 1)
                            {
                                break;
                            }
                        }
                        CounterCards++;
                        if (CounterCards == 5)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        return;
                    }


                }
                // reset cursor 
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void TakeMeHome()
        {
            int indexDepOrAri;
            DateTime trainTime;

            if (chbSpecifyTime.Checked)
            {
                if (rdbDeparture.Checked)
                {
                    indexDepOrAri = 0;
                }
                else
                {
                    indexDepOrAri = 1;
                }
                trainTime = dtpTime.Value;
            }
            else
            {
                indexDepOrAri = 0;
                trainTime = DateTime.Now;
            }

            Connections _connections = _transportHandler.GetConnections(cmbStartLocation.Text, "Rothenburg", indexDepOrAri, trainTime, trainTime);

            foreach (Connection connection in _connections.ConnectionList)
            {
                GetConnectionswithCards(connection);
            }
        }

        private void cmbStartLocation_TextUpdate(object sender, EventArgs e)
        {
            GetStationRecomendations(cmbStartLocation);
            cmbStartLocation.SelectionStart = cmbStartLocation.Text.Length;
        }

        private void cmbDestinationLocation_TextUpdate(object sender, EventArgs e)
        {
            GetStationRecomendations(cmbDestinationLocation);
            cmbDestinationLocation.SelectionStart = cmbDestinationLocation.Text.Length;
        }

        private void chbSpecifyTime_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsCheckEnabled();
        }

        private void btnPictureReverser_Click(object sender, EventArgs e)
        {
            string textVor = "";
            string textNach = "";

            textVor = cmbStartLocation.Text.ToString();
            textNach = cmbDestinationLocation.Text.ToString();

            cmbStartLocation.Text = textNach;
            cmbDestinationLocation.Text = textVor;

        }

        private void rdbTimetable_CheckedChanged(object sender, EventArgs e)
        {
            btnPictureReverser.Visible = false;
            cmbDestinationLocation.Visible = false;
            lblDestinationLocation.Visible = false;
        }

        private void rdbFromTo_CheckedChanged(object sender, EventArgs e)
        {
            btnPictureReverser.Visible = true;
            cmbDestinationLocation.Visible = true;
            lblDestinationLocation.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                flpStationResult.Controls.Clear();

                if (rdbTimetable.Checked == true)
                {
                    GetPossibleStinations();

                }
                else if (rdbFromTo.Checked == true)
                {
                    GetStations();
                }
                if (rdbTakeMeHome.Checked == true)
                {
                    TakeMeHome();
                }
            }
            catch
            {
                if (cmbStartLocation.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie eine Startlocation ein!");
                }
                else if (cmbDestinationLocation.Text == "")
                {
                    MessageBox.Show("Bitte geben Sie eine Ankunftsstation ein");
                }
                return;
            }

        }

        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funktion noch nicht vorhanden \n" +
            "Error");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void grbLocation_Enter(object sender, EventArgs e)
        {

        }
    }
}