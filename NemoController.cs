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
            this.View.AddStartButtonClickHandler(new System.EventHandler(this.ClickOnStart));
            this.View.GetStopButton().Click += new System.EventHandler(this.ClickOnStopt);
            this.View.GetRestartButton().Click += new System.EventHandler(this.ClickOnRestart);
        }

        private void ClickOnStart(object sender, EventArgs e) {
            this.View.StartGameTimer();
            this.View.DisableStartButton();
            this.View.EnableStopButton();
            this.Model.IncreaseGameCount();
            this.View.SetInfoText(this.Model.GetInfoRunning());
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
        }
    }
}
