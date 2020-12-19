using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nemo
{
    public partial class NemoForm : Form
    {

        private List<Label> VisibleSquares;
        public NemoForm()
        {
            InitializeComponent();
            this.VisibleSquares = new List<Label>();
        }

        public void RenderTile(Panel tile)
        {
            this.panelSpiel.Controls.Add(tile);
        }

        public void ClearTiles()
        {
            this.panelSpiel.Controls.Clear();
        }

        public void StartGameTimer()
        {
            this.timerGame.Start();
        }

        public void StopGameTimer()
        {
            this.timerGame.Stop();
        }

        public Button GetStartButton()
        {
            return this.btnStart;
        }
        public Button GetStopButton()
        {
            return this.btnStop;
        }
        public Button GetRestartButton()
        {
            return this.btnRestart;
        }

        public void SetInfoText(String Text)
        {
            this.txtInfo.Text = Text;
        }

        public void DisableStartButton()
        {
            this.btnStart.Enabled = false;
        }

        public void EnableStartButton()
        {
            this.btnStart.Enabled = true;
        }

        public void DisableStopButton()
        {
            this.btnStop.Enabled = false;
        }
        public void EnableStopButton()
        {
            this.btnStop.Enabled = true;
        }
        public void DisableRestartButton()
        {
            this.btnRestart.Enabled = false;
        }
        public void EnableRestartButton()
        {
            this.btnRestart.Enabled = true;
        }
        public void AddStartButtonClickHandler(EventHandler Handler)
        {
            this.btnStart.Click += Handler;
        }
        public void AddStopButtonClickHandler(EventHandler Handler)
        {
            this.btnStop.Click += Handler;
        }

        public void AddRestartButtonClickHandler(EventHandler Handler)
        {
            this.btnRestart.Click += Handler;
        }
    }
}
