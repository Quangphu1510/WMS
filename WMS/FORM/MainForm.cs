using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class MainForm : Form
    {
        #region Win32 API
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        Point _dragStart;
        bool _dragging = false;
        private void EventMouse()
        {
            lblTitle.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _dragStart = e.Location;
                    _dragging = true;
                }
            };

            lblTitle.MouseMove += (s, e) =>
            {
                if (_dragging)
                {
                    if (Math.Abs(e.X - _dragStart.X) > 5 ||
                        Math.Abs(e.Y - _dragStart.Y) > 5)
                    {
                        _dragging = false;

                        ReleaseCapture();
                        SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                    }
                }
            };

            lblTitle.MouseUp += (s, e) =>
            {
                _dragging = false;
            };

            lblTitle.MouseDoubleClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    this.WindowState = FormWindowState.Maximized;
            };
        }

        #endregion

        Thread MainThread;
        public MainForm()
        {
            InitializeComponent();
            CreateMachineForm();
            EventMouse();
            MainThread = new Thread(ScanData);
            MainThread.IsBackground = true;
            MainThread.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Wide AA Focus Management System - Version: " + CGlobal.Version;
        }
        private void ScanData()
        {
            /*
            var fleetClient = new FleetApiClient(
                                    baseUrl: "http://192.168.1.50",
                                    token: "YOUR_API_TOKEN"
                                    );
            var task = new CreateTaskRequest
            {
                Mission = "DeliverMaterial",
                Source = "WH_A",
                Destination = "CNC_05",
                Priority = 1,
                Payload = "Pallet_01"
            };
            var result = await fleetClient.CreateTaskAsync(task);
            */
            for (int i = 0; i < 20; i++)
            {
                CGlobal.MachineInfor[i].MaterialInfor = new SMaterialInfor[2, 2];
                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Fail].Total = 100;
                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Input].Total = 100;
                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Fail].Total = 100;
                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Input].Total = 100;
            }

            while (true)
            {
                string strSQL = "SELECT * FROM MachineMaterial order by MachineName asc";
                DataTable tableMain = CGlobal.DataBase.GetDataTable(strSQL);
                if (tableMain != null)
                {
                    if (tableMain.Rows.Count == 20)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            //Remain
                            if (int.TryParse(tableMain.Rows[i]["FailACT"].ToString(), out int temp))
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Fail].Remain = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["FailSensor"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Fail].Remain = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["InputACT"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Input].Remain = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["InputSensor"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Input].Remain = temp;
                            }

                            //Total
                            if (int.TryParse(tableMain.Rows[i]["FailACTMax"].ToString(), out temp) && temp > 0)
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Fail].Total = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["FailSensorMax"].ToString(), out temp) && temp > 0)
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Fail].Total = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["InputACTMax"].ToString(), out temp) && temp > 0)
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.ACT, (int)eTray.Input].Total = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["InputSensorMax"].ToString(), out temp) && temp > 0)
                            {
                                CGlobal.MachineInfor[i].MaterialInfor[(int)eStage.Sensor, (int)eTray.Input].Total = temp;
                            }

                            //ProdRate
                            if (int.TryParse(tableMain.Rows[i]["Input"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].ProdRate.Input = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["Pass"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].ProdRate.Pass = temp;
                            }
                            if (int.TryParse(tableMain.Rows[i]["Fail"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].ProdRate.Fail = temp;
                            }
                            if (double.TryParse(tableMain.Rows[i]["TactTime"].ToString(), out double dtemp))
                            {
                                CGlobal.MachineInfor[i].ProdRate.TactTime = dtemp / 1000.0;
                            }

                            //Enable
                            if (int.TryParse(tableMain.Rows[i]["Enable"].ToString(), out temp))
                            {
                                CGlobal.MachineInfor[i].Enable = temp == 1 ? true : false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Database: Machine Count Checking Error!", "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        return;
                    }
                }
                Thread.Sleep(500);
            }
        }
        private void CreateMachineForm()
        {
            int iID = 0;
            for (int iRow = 0; iRow < 4; iRow++)
            {
                for (int iCol = 0; iCol < 5; iCol++)
                {
                    Form_MachineInfor machineForm = new Form_MachineInfor(iID);
                    machineForm.TopLevel = false;
                    machineForm.FormBorderStyle = FormBorderStyle.None;
                    machineForm.Dock = DockStyle.Fill;
                    tablePanelCenterForm.Controls.Add(machineForm, iCol, iRow);
                    machineForm.Show();
                    iID++;
                }
            }
        }
        private void mnstrExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd\r\nHH:mm:ss");
        }

        private void mnstrSetting_Click(object sender, EventArgs e)
        {
            Form_Setting settingForm = new Form_Setting();
            settingForm.StartPosition = FormStartPosition.CenterParent;
            settingForm.ShowDialog();
        }
    }
}
