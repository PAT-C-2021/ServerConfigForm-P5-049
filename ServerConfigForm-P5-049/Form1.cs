using ServiceMtk_P1_20160140049;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_049
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server On";
            labelKet.Text = "Klik Off untuk mematikan server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            labelOnOrOff.Text = "Server Off";
            labelKet.Text = "Klik On untuk mematikan server";
            Host.Close();
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
        }
    }
}
