using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nemo
{
    class Tile
    {
        
        private int Value;
        private Point Position;
        private Panel View;
        private Label Label;
        private Color Background;
        public Tile(int value, Point position)
        {
            this.Value = value;
            this.Position = position;
            this.InitializeComponent();
        }   
        
        private void InitializeComponent()
        {
            this.View = new Panel();
            this.Label = new Label();
            this.View.SuspendLayout();

            this.View.BackColor = System.Drawing.SystemColors.ControlLight;
            this.View.Controls.Add(this.Label);
            this.View.Location =this.Position;
            this.View.Name = $"tile{this.Value}";
            this.View.Padding = new System.Windows.Forms.Padding(5);
            this.View.Size = new System.Drawing.Size(131, 92);
            this.View.TabIndex = 0;


            this.Label.Text = this.Value.ToString();
            this.Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(5, 5);
            this.Label.Name = $"label${this.Value}";
            this.Label.Size = new System.Drawing.Size(121, 82);
            this.Label.TabIndex = 0;
            this.Label.Text = this.Value.ToString();
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.View.ResumeLayout(false);
        }

        public Panel GetView()
        {
            return this.View;
        }
    }
}
