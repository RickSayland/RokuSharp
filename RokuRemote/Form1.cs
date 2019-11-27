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

namespace RokuRemote
{
    public partial class RokuRemote : Form
    {
        private RokuAPI.RokuControl _r = new RokuAPI.RokuControl("http://192.168.1.13:8060");
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
