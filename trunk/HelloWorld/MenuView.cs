using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using Neonode.Forms;

namespace HelloWorld
{
    class MenuView : Menu
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ImageList imgList = new ImageList();
            imgList.Images.Add(base.GetType().Assembly, "HelloWorld.Properties.Resources.resources", "Settings");
            imgList.Images.Add(base.GetType().Assembly, "HelloWorld.Properties.Resources.resources", "About");
            this.ImageList = imgList;
            MenuPage menuPage = new MenuPage();
            menuPage.Buttons[0].Text = "Settings";
            menuPage.Buttons[0].ImageIndex = 0;
            menuPage.Buttons[0].Enabled = true;
            menuPage.Buttons[0].Click += new System.ComponentModel.CancelEventHandler(MenuViewSettings_Click);
            menuPage.Buttons[1].Text = "About";
            menuPage.Buttons[1].ImageIndex = 1;
            menuPage.Buttons[1].Enabled = true;
            menuPage.Buttons[1].Click += new System.ComponentModel.CancelEventHandler(MenuViewAbout_Click);
            this.TabPages.Add(menuPage);
        }

        void MenuViewSettings_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SettingsView settingsView = new SettingsView();
            settingsView.ShowDialog();
        }

        void MenuViewAbout_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show(this.Handle, "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\n\r\nHelloWorld example", "About HelloWorld");
        }
    }
}
