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
    public partial class Form_MachineInfor : Form
    {
        int _ID;
        public Form_MachineInfor(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void Form_MachineInfor_Load(object sender, EventArgs e)
        {
            lblMachineName.Text = "WAAF #" + (_ID+1).ToString();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (CGlobal.MachineInfor[_ID].MaterialInfor == null) return;
            if(!CGlobal.MachineInfor[_ID].Enable)
            {
                if (lblMachineName.BackColor != Color.Gray)
                {
                    lblMachineName.Text += " (Offline)";
                    lblMachineName.BackColor = Color.Gray;
                    lblAMRRequest.Text = "Offline";
                    lblAMRRequest.BackColor = Color.Gray;
                    progressBar_FailACT.Value = 0;
                    progressBar_InputACT.Value = 0;
                    progressBar_FailSS.Value = 0;
                    progressBar_InputSS.Value = 0;
                    lblInput.Text = "Input: 0";
                    lblPass.Text = "Pass: 0";
                    lblFail.Text = "Fail: 0";
                    lblYR.Text = "YR: 0.0%";
                    lblTT.Text = "TactTime: 0.00s";
                }
                return;
            }
            else if(lblMachineName.BackColor == Color.Gray)
            {
                lblMachineName.Text = lblMachineName.Text.Replace(" (Offline)", "");
                lblMachineName.BackColor = Color.FromArgb(36, 180, 99);
            }
            //TestRandom();
            progressBar_FailACT.Value = CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.ACT, (int)eTray.Fail].Remain * 100 / CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.ACT, (int)eTray.Fail].Total;
            progressBar_InputACT.Value = CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.ACT, (int)eTray.Input].Remain * 100 / CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.ACT, (int)eTray.Input].Total;
            progressBar_FailSS.Value = CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.Sensor, (int)eTray.Fail].Remain * 100 / CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.Sensor, (int)eTray.Fail].Total;
            progressBar_InputSS.Value = CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.Sensor, (int)eTray.Input].Remain * 100 / CGlobal.MachineInfor[_ID].MaterialInfor[(int)eStage.Sensor, (int)eTray.Input].Total;
            
            string[] temp = { "None", "Request", "Recieve", "Error" };
            Color[] colors = { Color.LightGray, Color.Yellow, Color.LimeGreen, Color.Red };
            lblAMRRequest.Text = temp[(int)CGlobal.MachineInfor[_ID].AMRRequest];
            lblAMRRequest.BackColor = colors[(int)CGlobal.MachineInfor[_ID].AMRRequest];

            lblInput.Text = "Input: " + CGlobal.MachineInfor[_ID].ProdRate.Input.ToString("N0");
            lblPass.Text = "Pass: " + CGlobal.MachineInfor[_ID].ProdRate.Pass.ToString("N0");
            lblFail.Text = "Fail: " + CGlobal.MachineInfor[_ID].ProdRate.Fail.ToString("N0");
            lblYR.Text = "YR: " + (CGlobal.MachineInfor[_ID].ProdRate.Input == 0 ? "0.0%" : ((double)CGlobal.MachineInfor[_ID].ProdRate.Pass / CGlobal.MachineInfor[_ID].ProdRate.Input).ToString("0.0%"));
            lblTT.Text = "TactTime: " + CGlobal.MachineInfor[_ID].ProdRate.TactTime.ToString("0.00") + "s";
        }

        private void TestRandom()
        {
            Random random = new Random();
            for (int iStage = 0; iStage < 2; iStage++)
            {
                for (int iTray = 0; iTray < 2; iTray++)
                {
                    CGlobal.MachineInfor[_ID].MaterialInfor[iStage, iTray].Remain = random.Next(0,100);
                }
            }
            CGlobal.MachineInfor[_ID].AMRRequest = (eAMR_RQ)random.Next(0,4);
        }
    }
}
