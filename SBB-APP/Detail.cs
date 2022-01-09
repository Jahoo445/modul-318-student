using System;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Models;
using SwissTransport.Core;

namespace SBB
{
    public partial class Detail : Form
    {
        private Connection connection;

        public Detail()
        {
            // init comopnent
            InitializeComponent();
        }
        


        private void Detail_Load(object sender, EventArgs e)
        {
            ltvConnections.Items.Clear();
            Console.WriteLine("runningload");
        }
    }
}

