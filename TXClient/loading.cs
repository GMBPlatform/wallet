using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXClient
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void lbl_loadings(string s)
        {
            lbl_loading.Text = s;
        }
        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}
