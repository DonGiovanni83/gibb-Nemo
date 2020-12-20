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
            this.components = new System.ComponentModel.Container();
            this.txtInfo = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.panelSpiel = new System.Windows.Forms.Panel();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.lblSpeedTitle = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointsTitle = new System.Windows.Forms.Label();
            this.panelSpeed = new System.Windows.Forms.Panel();
            this.panelSpeedProgress = new System.Windows.Forms.Panel();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            this.panelSpeed.SuspendLayout();
            this.panelSpeedProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(776, 100);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Info Text";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpiel.Location = new System.Drawing.Point(14, 126);
            this.panelSpiel.Name = "panelSpiel";
            this.panelSpiel.Size = new System.Drawing.Size(598, 389);
            this.panelSpiel.TabIndex = 2;
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Location = new System.Drawing.Point(16, 535);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(28, 15);
            this.lblMinSpeed.TabIndex = 4;
            this.lblMinSpeed.Text = "min";
            // 
            // lblSpeedTitle
            // 
            this.lblSpeedTitle.AutoSize = true;
            this.lblSpeedTitle.Location = new System.Drawing.Point(271, 535);
            this.lblSpeedTitle.Name = "lblSpeedTitle";
            this.lblSpeedTitle.Size = new System.Drawing.Size(94, 15);
            this.lblSpeedTitle.TabIndex = 5;
            this.lblSpeedTitle.Text = "Geschwindigkeit";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(562, 538);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(29, 15);
            this.lblMaxSpeed.TabIndex = 6;
            this.lblMaxSpeed.Text = "max";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(642, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 35);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(642, 288);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 35);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(642, 341);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(131, 35);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Neu starten";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.White;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(644, 165);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(129, 57);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointsTitle
            // 
            this.lblPointsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPointsTitle.Location = new System.Drawing.Point(642, 126);
            this.lblPointsTitle.Name = "lblPointsTitle";
            this.lblPointsTitle.Size = new System.Drawing.Size(131, 32);
            this.lblPointsTitle.TabIndex = 9;
            this.lblPointsTitle.Text = "Punkte:";
            this.lblPointsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSpeed
            // 
            this.panelSpeed.BackColor = System.Drawing.Color.LightBlue;
            this.panelSpeed.Controls.Add(this.panelSpeedProgress);
            this.panelSpeed.Location = new System.Drawing.Point(16, 566);
            this.panelSpeed.Name = "panelSpeed";
            this.panelSpeed.Size = new System.Drawing.Size(596, 42);
            this.panelSpeed.TabIndex = 10;
            // 
            // panelSpeedProgress
            // 
            this.panelSpeedProgress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSpeedProgress.Controls.Add(this.lblSpeed);
            this.panelSpeedProgress.Location = new System.Drawing.Point(5, 5);
            this.panelSpeedProgress.Name = "panelSpeedProgress";
            this.panelSpeedProgress.Size = new System.Drawing.Size(339, 32);
            this.panelSpeedProgress.TabIndex = 10;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.Color.LightBlue;
            this.lblSpeed.Location = new System.Drawing.Point(0, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.lblSpeed.Size = new System.Drawing.Size(339, 32);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "5";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 657);
            this.Controls.Add(this.panelSpeed);
            this.Controls.Add(this.lblPointsTitle);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMaxSpeed);
            this.Controls.Add(this.lblSpeedTitle);
            this.Controls.Add(this.lblMinSpeed);
            this.Controls.Add(this.panelSpiel);
            this.Controls.Add(this.InfoPanel);
            this.Name = "NemoForm";
            this.Text = "Nemo";
            this.InfoPanel.ResumeLayout(false);
            this.panelSpeed.ResumeLayout(false);
            this.panelSpeedProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel panelSpiel;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.Label lblSpeedTitle;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointsTitle;
        private System.Windows.Forms.Panel panelSpeed;
        private System.Windows.Forms.Panel panelSpeedProgress;
        private System.Windows.Forms.Label lblSpeed;
    }
}

