using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DnsChanger;
using DnsChanger.Exceptions;
using DnsChanger.Config;
using System.Diagnostics;

namespace DnsChangerApp
{
    public partial class DnsChooser : Form
    {
        private const string m_manual = "Manual";

        public DnsChooser()
        {
            InitializeComponent();
        }

        private void DnsChooser_Load(object sender, EventArgs e)
        {
        }

        private void cmbAvailableDns_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            string provider = cmbAvailableDns.SelectedItem as string;

            DnsServerElement server = null;

                server = new DnsServerElement
                {
                    Name = "Manual",
                    ConfigServers = "87.118.111.215, 81.174.67.134"
                };

                try
                {
                    if (!DnsHelper.SetDnsServers(server.Servers))
                        MessageBox.Show("Changes require a reboot");
                    MessageBox.Show("Done it! In some minutes you'll be protected!");
                    ProcessStartInfo sInfo = new ProcessStartInfo("http://fooldns.com/done_install");
                    Process.Start(sInfo);
                }
                catch (InvalidServerException ex)
                {
                    MessageBox.Show("There was a problem. Please consult Knowledgebase!");
                }
        }

        private void btnSaveCurrent_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fooldns.org/from_win_app");
            Process.Start(sInfo);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fooldns.org/from_win_app");
            Process.Start(sInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fooldns.org/from_win_app");
            Process.Start(sInfo);
        }
    }
}
