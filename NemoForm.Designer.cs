namespace Nemo
{
    partial class NemoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInfo = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.panelSpiel = new System.Windows.Forms.Panel();
            this.lblMinVelocity = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblMaxVelocity = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtInfo.Location = new System.Drawing.Point(347, 42);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(77, 21);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Info Text";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InfoPanel.Controls.Add(this.txtInfo);
            this.InfoPanel.Location = new System.Drawing.Point(12, 12);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(776, 100);
            this.InfoPanel.TabIndex = 1;
            // 
            // panelSpiel
            // 
            this.panelSpiel.Location = new System.Drawing.Point(14, 126);
            this.panelSpiel.Name = "panelSpiel";
            this.panelSpiel.Size = new System.Drawing.Size(598, 389);
            this.panelSpiel.TabIndex = 2;
            // 
            // lblMinVelocity
            // 
            this.lblMinVelocity.AutoSize = true;
            this.lblMinVelocity.Location = new System.Drawing.Point(16, 535);
            this.lblMinVelocity.Name = "lblMinVelocity";
            this.lblMinVelocity.Size = new System.Drawing.Size(28, 15);
            this.lblMinVelocity.TabIndex = 4;
            this.lblMinVelocity.Text = "min";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(271, 535);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(94, 15);
            this.lblVelocity.TabIndex = 5;
            this.lblVelocity.Text = "Geschwindigkeit";
            // 
            // lblMaxVelocity
            // 
            this.lblMaxVelocity.AutoSize = true;
            this.lblMaxVelocity.Location = new System.Drawing.Point(562, 538);
            this.lblMaxVelocity.Name = "lblMaxVelocity";
            this.lblMaxVelocity.Size = new System.Drawing.Size(29, 15);
            this.lblMaxVelocity.TabIndex = 6;
            this.lblMaxVelocity.Text = "max";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 573);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(596, 29);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // NemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 657);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMaxVelocity);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.lblMinVelocity);
            this.Controls.Add(this.panelSpiel);
            this.Controls.Add(this.InfoPanel);
            this.Name = "NemoForm";
            this.Text = "Nemo";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel panelSpiel;
        private System.Windows.Forms.Label lblMinVelocity;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblMaxVelocity;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

