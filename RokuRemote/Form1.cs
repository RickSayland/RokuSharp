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
        private RokuAPI.RokuControl _r = new RokuAPI.RokuControl(ConfigurationManager.AppSettings["LocalIPAddress"]);
        public RokuRemote()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _r.PressUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _r.PressButton((sender as Button).Text);
        }
    }
}
