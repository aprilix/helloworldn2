using System;

using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Neonode.Forms;

namespace HelloWorld
{
    class MainView : CustomView
    {
        private string sText = "";
        private int iClicks = 0;

        public string Text
        {
            get { return sText; }
            set { sText = value; }
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Title.Text = "Hello World";
            this.Description.Text = "Neonode.Forms.CustomView example";
            this.ToolsSweep.Enabled = true;
            this.ToolsSweep.Occurred += new System.ComponentModel.CancelEventHandler(ToolsSweep_Occurred);
            this.Paint += new EventHandler<PaintEventArgs>(MainView_Paint);
            this.Click += new EventHandler<System.Windows.Forms.MouseEventArgs>(MainView_Click);
        }

        private void ToolsSweep_Occurred(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MenuView menuView = new MenuView();
            menuView.ShowDialog();
        }

        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 12f, FontStyle.Regular);
            Graphics graphics = e.Graphics;
            graphics.DrawString("Number of clicks: " + iClicks.ToString(), font, new SolidBrush(this.Title.TextColor), (float)8, (float)30);
        }

        void MainView_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            iClicks++;
            this.Refresh();
        }
    }
}
