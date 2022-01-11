using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_APP
{
    public partial class Stationen_Karten : UserControl
    {
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public Stationen_Karten()
        {
            InitializeComponent();
        }


        #region karte
        private string _titel;
        private string _info1Bez;
        private string _info2Bez;
        private string _info3Bez;
        private string _info1;
        private string _info2;
        private string _info3;
        private string _verspaetungBez;
        private string _verspaetung1;



        [Category("Custom Props")]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; lblCardTitel.Text = value; }
        }



        [Category("Custom Props")]
        public string Info1Bez
        {
            get { return _info1Bez; }
            set { _info1Bez = value; lblCardDepartureTime.Text = value; }
        }



        [Category("Custom Props")]
        public string Info2Bez
        {
            get { return _info2Bez; }
            set { _info2Bez = value; lblCardDestinationTime.Text = value; }
        }

        [Category("Custom Props")]
        public string Info3Bez
        {
            get { return _info3Bez; }
            set { _info3Bez = value; lblCardDuration.Text = value; }
        }


        [Category("Custom Props")]
        public string Info1
        {
            get { return _info1; }
            set { _info1 = value; lblCardDepartureTimePlaceholder.Text = value; }
        }



        [Category("Custom Props")]
        public string Info2
        {
            get { return _info2; }
            set { _info2 = value; lblCardDestinationTimePlaceholder.Text = value; }
        }

        [Category("Custom Props")]
        public string Info3
        {
            get { return _info3; }
            set { _info3 = value; lblCardDurationPlaceholder.Text = value; }
        }



            [Category("Custom Props")]
        public string VerspaetungBez
        {
            get { return _verspaetungBez; }
            set { _verspaetungBez = value; lblCardDelay.Text = value; }
        }


        [Category("Custom Props")]
        public string Verspaetung1
        {
            get { return _verspaetung1; }
            set { _verspaetung1 = value; lblCardDelayPlaceholder.Text = value; }
        }
        #endregion


        private void Stationen_Karten_Load(object sender, EventArgs e)
        {

        }
    }
}
