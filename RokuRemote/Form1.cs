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
        private RokuAPI.RokuControl _r;
        public RokuRemote()
        {
            InitializeComponent();
            _r = new RokuAPI.RokuControl(ConfigurationManager.AppSettings["URI"]);
            setApps();
        }
        private void setApps()
        {
            this.lbApps.DisplayMember = "value";
            this.lbApps.ValueMember = "id";
            var apps = _r.GetListOfApps();
            foreach (App a in apps)
            {
                this.lbApps.Items.Add(a);
            }
            this.lbApps.Sorted = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _r.PressUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _r.PressDown();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _r.PressLeft();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _r.PressRight();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _r.PressBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _r.PressHome();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            _r.PressVolumeUp();
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            _r.PressVolumeDown();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _r.PressSelect();
        }

        private void btnLaunchApp_Click(object sender, EventArgs e)
        {
            if (this.lbApps.SelectedItem != null) _r.LaunchApp((this.lbApps.SelectedItem as RokuAPI.App).Id);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            _r.PressRev();
        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            _r.PressFwd();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            _r.PressPlay();
        }
    }
}
