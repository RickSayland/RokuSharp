using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RokuAPI;
using System.Configuration;

namespace RokuRemote
{
    public partial class RokuRemote : Form
    {
        public readonly RokuAPI.RokuControl ROKU = new RokuAPI.RokuControl(ConfigurationManager.AppSettings["URI"]);
        public RokuRemote()
        {
            InitializeComponent();
            setApps();
        }
        private void setApps()
        {
            this.lbApps.DisplayMember = "value";
            this.lbApps.ValueMember = "id";
            foreach (App a in ROKU.Apps)
            {
                this.lbApps.Items.Add(a);
            }
            this.lbApps.Sorted = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ROKU.PressUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ROKU.PressDown();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ROKU.PressLeft();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ROKU.PressRight();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ROKU.PressBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ROKU.PressHome();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            ROKU.PressVolumeUp();
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            ROKU.PressVolumeDown();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ROKU.PressSelect();
        }

        private void btnLaunchApp_Click(object sender, EventArgs e)
        {
            if (this.lbApps.SelectedItem != null) ROKU.LaunchApp((this.lbApps.SelectedItem as RokuAPI.App).Id);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            ROKU.PressRev();
        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            ROKU.PressFwd();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            ROKU.PressPlay();
        }
    }
}
