namespace WMS
{
    partial class Form_Setting
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
            this.chbSimulation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbSimulation
            // 
            this.chbSimulation.AutoSize = true;
            this.chbSimulation.Location = new System.Drawing.Point(27, 27);
            this.chbSimulation.Name = "chbSimulation";
            this.chbSimulation.Size = new System.Drawing.Size(74, 17);
            this.chbSimulation.TabIndex = 0;
            this.chbSimulation.Text = "Simulation";
            this.chbSimulation.UseVisualStyleBackColor = true;
            this.chbSimulation.CheckedChanged += new System.EventHandler(this.chbSimulation_CheckedChanged);
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 64);
            this.Controls.Add(this.chbSimulation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbSimulation;
    }
}