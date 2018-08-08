using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            cbAction.SelectedIndex = 0;
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0) {
                lblToDir.Text = "Dir: ";
                lblFromDir.Visible = false;
                txtFromDir.Visible = false;
                lblToDir.Visible = true;
                txtToDir.Visible = true;
                btnAction.Text = "Delete";
            } else if (cbAction.SelectedIndex == 1) {
                lblFromDir.Text = "From Dir: ";
                lblToDir.Text = "To Dir: ";
                lblFromDir.Visible = true;
                txtFromDir.Visible = true;
                lblToDir.Visible = true;
                txtToDir.Visible = true;
                btnAction.Text = "Move";
            } else if (cbAction.SelectedIndex == 2) {
                lblToDir.Text = "Dir: ";
                lblFromDir.Visible = false;
                txtFromDir.Visible = false;
                lblToDir.Visible = true;
                txtToDir.Visible = true;
                btnAction.Text = "Sort";
            } else if (cbAction.SelectedIndex == 3) {
                lblToDir.Text = "Dir: ";
                lblFromDir.Visible = false;
                txtFromDir.Visible = false;
                lblToDir.Visible = true;
                txtToDir.Visible = true;
                btnAction.Text = "Create Files";
            }
        }
    }
}
