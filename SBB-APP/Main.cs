using System;
using System.Windows.Forms;
using SBB;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBB_APP
{
    public partial class Main : Form
    {
        private readonly Transport _transportHandler;
        private Detail _detailview;
        public Main()
        {
            _transportHandler = new Transport();
            _detailview = new Detail();
            InitializeComponent();
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

        private void AddConnectionToList(Connection connection)
        {
            string[] row = new string[]
            {
                connection.From.Station.Name,
                connection.From.Departure.ToString(),
                connection.To.Station.Name,
                connection.To.Arrival.ToString(),
                (DateTime.Parse(connection.To.Arrival.ToString())-DateTime.Parse(connection.From.Departure.ToString())).ToString(),
                "-"
            };

            ltvConnections.Items.Add(new ListViewItem(row)
            {
                Tag = connection
            });
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

        private void GetStations()
        {
            int lala;
            DateTime trainTime;

            if (chbSpecifyTime.Checked)
            {
                if (rdbDeparture.Checked)
                {
                    lala = 0;
                }
                else
                {
                    lala = 1;
                }
                trainTime = dtpTime.Value;
            }
            else
            {
                lala = 0;
                trainTime = DateTime.Now;
            }
            Connections _connections = _transportHandler.GetConnections(cmbStartLocation.Text, cmbDestinationLocation.Text);

            ltvConnections.Items.Clear();

            foreach (Connection connection in _connections.ConnectionList)
            {
                AddConnectionToList(connection);
            }
        }

        private void cmbStartLocation_TextUpdate(object sender, EventArgs e)
        {
            GetStationRecomendations(cmbStartLocation);
        }

        private void cmbDestinationLocation_TextUpdate(object sender, EventArgs e)
        {
            GetStationRecomendations(cmbDestinationLocation);
        }

        private void getPossibleStation()
        {
            try
            {
                Station station = _transportHandler.GetStations(cmbStartLocation.Text).StationList.ElementAt(0);

                StationBoardRoot board = _transportHandler.GetStationBoard(station.Name, station.Id);

                Cursor.Current = Cursors.WaitCursor;

                foreach (StationBoard bord in board.Entries)
                {
                    try
                    {
                        Station to_station = _transportHandler.GetStations(bord.To).StationList.ElementAt(0);

                        Connection connection = _transportHandler.GetConnections(station.Name, to_station.Name);

                        AddConnectionToList(connection);
                    }
                    catch
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbDestinationLocation.Text == "")
            {
                getPossibleStation();
            }
            else
            {
                GetStations();
            }
        }

        private void chbSpecifyTime_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsCheckEnabled();
        }

        private void ltvConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvConnections.SelectedItems.Count <= 0 || ltvConnections.SelectedIndices[0] < 0)
            {
                return;
            }

            ListViewItem item = ltvConnections.SelectedItems[0];
            Console.WriteLine(item.Tag);

            _detailview.Tag = item.Tag;
            _detailview.ShowDialog(this);
        }
    }
}