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
    public partial class Form1 : Form
    {
        student a;
        chitieu hh;
        BLL BLL = new BLL();
        public Form1(student a )
        {
            this.a = a;
            this.hh = BLL.checkchitieu(a.Id);
            InitializeComponent();
            textBox1.Text = a.Salary.ToString();
            textBox3.Text = hh.Doan.ToString();
            textBox4.Text = hh.Quanao.ToString();
            textBox5.Text = hh.Dilai.ToString();
            textBox6.Text = hh.Mypham.ToString();
            textBox10.Text = hh.Yte.ToString();
            textBox9.Text = hh.Giaoluu.ToString();
            textBox8.Text = hh.Tiennha.ToString();
            textBox7.Text = hh.Giaoduc.ToString();
            textBox11.Text = hh.Other.ToString();
        }
        Form activeForm = new Form();
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            this.a = BLL.getstubyid(a.Id);
            textBox1.Text = a.Salary.ToString();
            textBox2.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Form2(a.Id));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            int s1 = int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text);
            chitieu c = new chitieu(a.Id,int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox10.Text), int.Parse(textBox9.Text), int.Parse(textBox8.Text), int.Parse(textBox7.Text),dateTimePicker1.Value.ToString("yyyy-MM-dd"), int.Parse(textBox11.Text));
            BLL.addchitieu(c);
            BLL.updatect(c);
            int s2 = hh.Doan + hh.Tiennha + hh.Giaoluu + hh.Dilai + hh.Yte + hh.Quanao + hh.Mypham + hh.Giaoduc + hh.Other;
            int b = a.Salary - s1 + s2;
            a.Salary = b;
            BLL.updatestu(a);
            textBox2.Text = b.ToString();
            this.hh = BLL.getchitieu(a.Id,dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            if(s1 > 1000)
            {
                MessageBox.Show("Dữ liệu đã được lưu");
            }
            else
            {
                BLL.delct(c);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không được để trống");
            }
            finally
            {

            textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text = "0"; textBox6.Text = "0"; textBox7.Text = "0"; textBox8.Text = "0"; textBox9.Text = "0"; textBox10.Text = "0"; textBox11.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.hh = BLL.getchitieu(a.Id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            textBox3.Text = hh.Doan.ToString();
            textBox4.Text = hh.Quanao.ToString();
            textBox5.Text = hh.Dilai.ToString();
            textBox6.Text = hh.Mypham.ToString();
            textBox10.Text = hh.Yte.ToString();
            textBox9.Text = hh.Giaoluu.ToString();
            textBox8.Text = hh.Tiennha.ToString();
            textBox7.Text = hh.Giaoduc.ToString();
            textBox11.Text = hh.Other.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7(a));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
            this.Close();
        }
    }
}
