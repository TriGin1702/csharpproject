using ktgk;
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
    public partial class Form6 : Form
    {
        string id;
        BLL BLL = new BLL();
        student a;
        public Form6(string id)
        {
            this.id = id;
            InitializeComponent();
            this.a = BLL.getstubyid(id);
            textBox1.Text = a.Tk; textBox2.Text = a.Mk;
            textBox3.Text = a.Name; textBox4.Text = a.Age.ToString(); textBox5.Text = a.Salary.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox5.Text) >= 3000000 && !textBox3.Text.Equals("") && !textBox1.Text.Equals("")&& !textBox2.Text.Equals("")&& int.Parse(textBox4.Text) >= 18)
            {
                student b = new student(this.id, textBox3.Text, textBox1.Text, textBox2.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                BLL.updatestu(b);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và hợp lệ");
            }
        }
    }
}
