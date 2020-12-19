using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo
{
    class NemoController
    {
        private NemoModel Model;
        private NemoForm View;

        public NemoController(NemoModel model, NemoForm view)
        {
            this.Model = model;
            this.View = view;

            //this.View.GetInfoText().Text = this.Model.GetInfoIdle();
            this.SubscribeView();
        }

        private void SubscribeView()
        {
            this.View.AddStartButtonClickHandler(new EventHandler(this.ClickOnStart));
            this.View.AddStopButtonClickHandler(new EventHandler(this.ClickOnStopt));
            this.View.AddRestartButtonClickHandler(new EventHandler(this.ClickOnRestart));

            this.View.SetOnTickAction(new EventHandler(this.HandleTick));
        }

        public void HandleTick(object sender, EventArgs e)
        {
            this.View.MoveTiles(this.Model.GetGameSpeed());
        }
        private void ClickOnStart(object sender, EventArgs e) {
            this.View.StartGameTimer();
            this.View.DisableStartButton();
            this.View.EnableStopButton();
            this.Model.IncreaseGameCount();
            this.View.SetInfoText(this.Model.GetInfoRunning());
            this.DrawTile();
        }
        private void ClickOnStopt(object sender, EventArgs e) {
            this.View.StopGameTimer();
            this.View.DisableStopButton();
            this.View.EnableRestartButton();
            this.View.SetInfoText(this.Model.GetInfoErrorStopped());
        }
        private void ClickOnRestart(object sender, EventArgs e) {
            this.View.DisableRestartButton();
            this.View.EnableStartButton();
            this.View.SetInfoText(this.Model.GetInfoIdle());
            this.ClearTiles();
        }

        private void DrawTile()
        {
                        Tile tile = new Tile(2, new System.Drawing.Point(10, 10));
            this.View.RenderTile(tile.GetView());
        }

        private void ClearTiles()
        {
            this.View.ClearTiles();
        }
    }
}
