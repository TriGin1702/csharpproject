using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktgt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (checkBox1.Checked == false && int.Parse(textBox1.Text) >= 3000000)
            {
                textBox3.Text = (int.Parse(textBox1.Text)/5) + " VNĐ";
                textBox8.Text = (int.Parse(textBox1.Text) / 5) + " VNĐ";
                textBox4.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
                textBox5.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
                textBox6.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
                textBox7.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
                textBox9.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
                textBox10.Text = (int.Parse(textBox1.Text) / 10) + " VNĐ";
            }
            if (checkBox1.Checked == true && int.Parse(textBox1.Text) >= 3000000)
            {
                textBox3.Text = (int.Parse(textBox1.Text) / 8) + " VNĐ";
                textBox8.Text = (int.Parse(textBox1.Text) / 5) + " VNĐ";
                textBox4.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
                textBox5.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
                textBox6.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
                textBox7.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
                textBox9.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
                textBox10.Text = (int.Parse(textBox1.Text) / 12) + " VNĐ";
            }
            else if(int.Parse(textBox1.Text) < 3000000)
            {
                MessageBox.Show("Vui lòng nhập số tiền lớn hơn 3000000 VNĐ ");
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }
    }
}
