using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nemo
{
    public partial class NemoForm : Form
    {
        private EventHandler ClickOnWrongTileHandler;
        private Action<int> ClickOnRedTileCallback;
        public NemoForm()
        {
            InitializeComponent();
        }


        public void RenderTile(int value, int x, int y,int width, int height, Color background)
        {

            Control[] tiles = this.panelSpiel.Controls.Find($"tile{value}", false);
            if (tiles.Length != 0) {
                tiles[0].Location = new Point(x, y);
            }
            else
            {
                Point location = new Point(x, y);

                Panel newTilePanel = this.CreateNewPanel(value, width, height, location);
                Label newTileLabel = this.CreateNewLabel(value,width-10, height-10, background);
                newTilePanel.SuspendLayout();


                newTilePanel.Controls.Add(newTileLabel);
                newTilePanel.ResumeLayout(false);

                this.panelSpiel.Controls.Add(newTilePanel);

                this.RegisterOnClickEventOnLabel(newTileLabel, value);
                
            }
        }

        private Label CreateNewLabel(int value, int width, int height, Color background)
        {
            Label newLabel = new Label();
            newLabel.Text = value.ToString();
            newLabel.BackColor = background;
            newLabel.Dock = DockStyle.Fill;
            newLabel.Location = new Point(5, 5);
            newLabel.Name = $"label${value}";
            newLabel.Size = new Size(width, height);
            newLabel.TabIndex = 0;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;

            return newLabel;
        }

        private Panel CreateNewPanel(int value, int width, int height, Point location)
        {
            Panel newPanel = new Panel();
            newPanel.BackColor = SystemColors.ControlLight;

            newPanel.Location = location;
            newPanel.Name = $"tile{value}";
            newPanel.Padding = new Padding(5);
            newPanel.Size = new Size(width, height);
            newPanel.TabIndex = 0;

            return newPanel;
        }

        private void RegisterOnClickEventOnLabel(Label label, int value)
        {
            if (label.BackColor== Color.Red)
            {
                label.Click += new EventHandler((s, e) => {
                    label.BackColor = Color.Pink;
                    this.ClickOnRedTileCallback.Invoke(value);
                });
            } else
            {
                label.Click += this.ClickOnWrongTileHandler; 
            }
        }

        public bool BoardContainsMissedRedTiles()
        {
            bool containsMissing = false;
            List<Control> redTiles = this.GetRedTiles();
            foreach (Control redTile in redTiles)
            {
                if(redTile.Location.Y >= this.panelSpiel.Height)
                {
                    containsMissing = true;
                }
            }
            return containsMissing;
        }

        private List<Control> GetRedTiles()
        {
            List<Control> redTiles = new List<Control>();

            foreach (Control tile in this.panelSpiel.Controls)
            {
                if(tile.Controls[0].BackColor == Color.Red)
                {
                    redTiles.Add(tile);
                }
            }

            return redTiles;
        }

        public void AddClickOnWrongTileHandler(EventHandler handler)
        {
            this.ClickOnWrongTileHandler = handler;
        }
        public void AddClickOnRedTileCallback(Action<int> callback)
        {
            this.ClickOnRedTileCallback = callback;
        }
        public void AddStartButtonClickHandler(EventHandler handler)
        {
            this.btnStart.Click += handler;
        }
        public void AddStopButtonClickHandler(EventHandler handler)
        {
            this.btnStop.Click += handler;
        }

        public void AddRestartButtonClickHandler(EventHandler handler)
        {
            this.btnRestart.Click += handler;
        }

        public void SetOnTickAction(EventHandler handler)
        {
            this.timerGame.Tick += handler;
        }

        public void SetPoints(int points)
        {
            this.lblPoints.Text = points.ToString();
        }
        public int GetBoardHeight()
        {
            return this.panelSpiel.Height;
        }

        public int GetBoardWidth()
        {
            return this.panelSpiel.Width;
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

        public void SetInfoText(String text)
        {
            this.txtInfo.Text = text;
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

        public void ClearBoard()
        {
            this.panelSpiel.Controls.Clear();
        }
    }
}
