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
        public NemoForm()
        {
            InitializeComponent();
        }

        public Button getStartButton()
        {
            return this.btnStart;
        }
        public Button getStopButton()
        {
            return this.btnStop;
        }
        public Button getRestartButton()
        {
            return this.btnRestart;
        }
    }
}
