namespace WMS
{
    partial class Form_MachineInfor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAMRRequest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar_InputSS = new CustomProgressBar();
            this.progressBar_InputACT = new CustomProgressBar();
            this.progressBar_FailACT = new CustomProgressBar();
            this.progressBar_FailSS = new CustomProgressBar();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblYR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMachineName
            // 
            this.lblMachineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.lblMachineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblMachineName.ForeColor = System.Drawing.Color.White;
            this.lblMachineName.Location = new System.Drawing.Point(3, 0);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblMachineName.Size = new System.Drawing.Size(337, 25);
            this.lblMachineName.TabIndex = 1;
            this.lblMachineName.Text = "WAAF #01";
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.65578F));
            this.tableLayoutPanel1.Controls.Add(this.lblAMRRequest, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_InputSS, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_InputACT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_FailACT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_FailSS, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 163);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblAMRRequest
            // 
            this.lblAMRRequest.BackColor = System.Drawing.Color.DarkGray;
            this.lblAMRRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAMRRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMRRequest.ForeColor = System.Drawing.Color.Black;
            this.lblAMRRequest.Location = new System.Drawing.Point(109, 133);
            this.lblAMRRequest.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblAMRRequest.Name = "lblAMRRequest";
            this.lblAMRRequest.Size = new System.Drawing.Size(223, 25);
            this.lblAMRRequest.TabIndex = 4;
            this.lblAMRRequest.Text = "No Request";
            this.lblAMRRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Request AMR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input ACT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Sensor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fail ACT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fail Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar_InputSS
            // 
            this.progressBar_InputSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_InputSS.Location = new System.Drawing.Point(109, 37);
            this.progressBar_InputSS.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.progressBar_InputSS.Name = "progressBar_InputSS";
            this.progressBar_InputSS.Size = new System.Drawing.Size(223, 22);
            this.progressBar_InputSS.TabIndex = 2;
            this.progressBar_InputSS.Text = "customProgressBar2";
            this.progressBar_InputSS.Value = 24;
            // 
            // progressBar_InputACT
            // 
            this.progressBar_InputACT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_InputACT.Location = new System.Drawing.Point(109, 5);
            this.progressBar_InputACT.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.progressBar_InputACT.Name = "progressBar_InputACT";
            this.progressBar_InputACT.Size = new System.Drawing.Size(223, 22);
            this.progressBar_InputACT.TabIndex = 2;
            this.progressBar_InputACT.Text = "customProgressBar2";
            this.progressBar_InputACT.Value = 60;
            // 
            // progressBar_FailACT
            // 
            this.progressBar_FailACT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_FailACT.Location = new System.Drawing.Point(109, 69);
            this.progressBar_FailACT.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.progressBar_FailACT.Name = "progressBar_FailACT";
            this.progressBar_FailACT.Size = new System.Drawing.Size(223, 22);
            this.progressBar_FailACT.TabIndex = 2;
            this.progressBar_FailACT.Text = "customProgressBar2";
            // 
            // progressBar_FailSS
            // 
            this.progressBar_FailSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_FailSS.Location = new System.Drawing.Point(109, 101);
            this.progressBar_FailSS.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.progressBar_FailSS.Name = "progressBar_FailSS";
            this.progressBar_FailSS.Size = new System.Drawing.Size(223, 22);
            this.progressBar_FailSS.TabIndex = 2;
            this.progressBar_FailSS.Text = "customProgressBar2";
            this.progressBar_FailSS.Value = 90;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(74, 20);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(60, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Pass: 1500";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(139, 20);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(35, 13);
            this.lblFail.TabIndex = 0;
            this.lblFail.Text = "Fail: 0";
            // 
            // lblYR
            // 
            this.lblYR.AutoSize = true;
            this.lblYR.Location = new System.Drawing.Point(183, 20);
            this.lblYR.Name = "lblYR";
            this.lblYR.Size = new System.Drawing.Size(57, 13);
            this.lblYR.TabIndex = 0;
            this.lblYR.Text = "YR: 99.8%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTT);
            this.groupBox1.Controls.Add(this.lblYR);
            this.groupBox1.Controls.Add(this.lblFail);
            this.groupBox1.Controls.Add(this.lblInput);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(3, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production Rate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMachineName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 244);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(6, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(61, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input: 1500";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(250, 20);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(75, 13);
            this.lblTT.TabIndex = 0;
            this.lblTT.Text = "TactTime: 20s";
            // 
            // Form_MachineInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(363, 264);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MachineInfor";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form_MachineInfor";
            this.Load += new System.EventHandler(this.Form_MachineInfor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomProgressBar progressBar_InputSS;
        private CustomProgressBar progressBar_InputACT;
        private CustomProgressBar progressBar_FailACT;
        private CustomProgressBar progressBar_FailSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAMRRequest;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblYR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblTT;
    }
}