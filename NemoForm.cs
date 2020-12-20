using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nemo
{
    public partial class NemoForm : Form
    {
        public NemoForm()
        {
            InitializeComponent();
        }

        public int GetBoardHeight()
        {
            return this.panelSpiel.Height;
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

        public void SetOnTickAction(EventHandler Handler)
        {
            this.timerGame.Tick += Handler;
        }
        public void ClearBoard()
        {
            this.panelSpiel.Controls.Clear();
        }

        public void RenderTile(int value, int x, int y, Color Background)
        {

            Control[] tiles = this.panelSpiel.Controls.Find($"tile{value}", false);
            if (tiles.Length != 0) {
                tiles[0].Location = new Point(x, y);
            }
            else
            {
                Point location = new Point(x, y);

                Panel newTilePanel = new Panel();
                Label newTileLabel = new Label();
                newTilePanel.SuspendLayout();

                newTilePanel.BackColor = SystemColors.ControlLight;

                newTilePanel.Location = location;
                newTilePanel.Name = $"tile{value}";
                newTilePanel.Padding = new Padding(5);
                newTilePanel.Size = new Size(131, 92);
                newTilePanel.TabIndex = 0;


                newTileLabel.Text = value.ToString();
                newTileLabel.BackColor = Background;
                newTileLabel.Dock = DockStyle.Fill;
                newTileLabel.Location = new Point(5, 5);
                newTileLabel.Name = $"label${value}";
                newTileLabel.Size = new Size(121, 82);
                newTileLabel.TabIndex = 0;
                newTileLabel.TextAlign = ContentAlignment.MiddleCenter;

                newTilePanel.Controls.Add(newTileLabel);
                newTilePanel.ResumeLayout(false);

                this.panelSpiel.Controls.Add(newTilePanel);
            }
        }
    }
}
