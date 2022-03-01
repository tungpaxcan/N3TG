using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N3TG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUserName.Text;
            string Pass = txtPass.Text;


           if(User == "admin" && Pass == "admin")
            {
                MessageBox.Show("Chúc mừng đã đăng nhập thành công!!!");
            }
        }
    }
}
