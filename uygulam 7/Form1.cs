using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulam_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEke_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbMeyveller.Items.Add(txtMeyve.Text);
        }
    }
}
