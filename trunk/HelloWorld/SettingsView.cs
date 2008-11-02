using System;

using System.Collections.Generic;
using System.Text;
using Neonode.Forms;

namespace HelloWorld
{
    class SettingsView : ListView
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Title.Text = "ListView example";
            
            ImageList imgList = new ImageList();
            imgList.Images.Add(base.GetType().Assembly, "HelloWorld.Properties.Resources.resources", "Happy");
            imgList.Images.Add(base.GetType().Assembly, "HelloWorld.Properties.Resources.resources", "Smile");
            imgList.Images.Add(base.GetType().Assembly, "HelloWorld.Properties.Resources.resources", "Tongue");
            this.ImageList = imgList;

            ListViewItem listItem1 = new ListViewItem("Example item 1", 0, "Example item 1 selected");
            ListViewItem listItem2 = new ListViewItem("Example item 2", 1, "Example item 2 selected");
            ListViewItem listItem3 = new ListViewItem("Example item 3", 2, "Example item 3 selected");

            Items.Add(listItem1);
            Items.Add(listItem2);
            Items.Add(listItem3);

            this.Click += new EventHandler(SettingsView_Click);

        }

        void SettingsView_Click(object sender, EventArgs e)
        {
            switch (this.SelectedItem.Index)
            {
                case 0:
                    MessageBox.Show(this.Handle, "You clicked on example item 1");
                    break;

                case 1:
                    MessageBox.Show(this.Handle, "You clicked on example item 2");
                    break;

                case 2:
                    MessageBox.Show(this.Handle, "You clicked on example item 3");
                    break;

                default:
                    break;
            }
        }
    }
}
