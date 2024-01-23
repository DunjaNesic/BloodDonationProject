using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Server
{
    public partial class FrmServer : Form
    {
        Server server = Server.Instance;        
        
        public FrmServer()
        {
            InitializeComponent();
            dgvCoordinators.DataSource = server.clients;
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;

            server.LoggedInClient += Server_LoggedInClient;
            server.LoggedOutClient += Server_LoggedOutClient;
        }

        private void Server_LoggedInClient(object sender, EventArgs e)
        {     
            Invoke(new Action(RefreshDataGridView));
        }

        private void Server_LoggedOutClient(object sender, EventArgs e)
        {       
            Invoke(new Action(RefreshDataGridView));
        }

        private void RefreshDataGridView()
        {
          
            var clientInfoList = server.clients
                .Select(client => new
                {
                    IME = client._coordinator.CoordinatorName,
                    PREZIME = client._coordinator.CoordinatorLastName,
                    IDENTIFIKACIONI_BROJ = client._coordinator.CoordinatorCode                   
                })
                .ToList();
    
            dgvCoordinators.DataSource = null;
            dgvCoordinators.DataSource = clientInfoList;
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            server.Start();
            Thread thread = new Thread(new ThreadStart(server.Listen));
            thread.Start();
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }
        private void btnStopServer_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }
    }
}
