using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                lblHello.ForeColor = Color.Green;
                lblHello.Text = "سلام" + " " + txtBox.Text;
            }
            else
            {
                lblHello.ForeColor = Color.Red;
                lblHello.Text = "لطفا نام خود را وارد کنید";
            }

        }

       
    }
}
