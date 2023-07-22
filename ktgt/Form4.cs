using ktgk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktgt
{
    public partial class Form4 : Form
    {
        BLL d = new BLL();
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form5().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verify();
        }
        public void verify()
        {
            if (d.checkTK(textBox1.Text, textBox2.Text).Id.Equals("no"))
            {
                MessageBox.Show("Sai Tài khoản hoặc Mật khẩu!");
            }
            else
            {
                this.Hide();
                new Form1(d.checkTK(textBox1.Text, textBox2.Text)).ShowDialog();
                this.Close();
            }
        }
        public void tb_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verify();
            }
        }
    }
}
