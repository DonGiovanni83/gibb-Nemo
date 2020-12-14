using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo
{
    class NemoController
    {
        private NemoModel model;
        private NemoForm view;

        public NemoController(NemoModel model, NemoForm view)
        {
            this.model = model;
            this.view = view;

            this.SubscribeView();
        }

        private void SubscribeView()
        {
            this.view.getStartButton().Click += new System.EventHandler(this.ClickOnStart);
            this.view.getStopButton().Click += new System.EventHandler(this.ClickOnStopt);
            this.view.getRestartButton().Click += new System.EventHandler(this.ClickOnRestart);
        }

        private void ClickOnStart(object sender, EventArgs e) { 
            
        }
        private void ClickOnStopt(object sender, EventArgs e) { }
        private void ClickOnRestart(object sender, EventArgs e) { }
    }
}
