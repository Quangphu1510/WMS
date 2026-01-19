using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class Form_Setting : Form
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void chbSimulation_CheckedChanged(object sender, EventArgs e)
        {
           CGlobal.SimulationMode = chbSimulation.Checked;
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            chbSimulation.Checked = CGlobal.SimulationMode;
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            string strCMD = "UPDATE MachineMaterial SET Enable = 0";
            CGlobal.DataBase.ExecuteNonQuery(strCMD);
        }
    }
}
