using ktgk;
using ktgt.DTO;
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
    public partial class Form7 : Form
    {
        student a;
        BLL BLL = new BLL();
        tienthu hh;
        public Form7(student a)
        {
            this.a = a;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.getalltienthu(a.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            int s1 = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text));
            if (s1> 10000)
            {
                DateTime b1 = DateTime.Parse(dateTimePicker1.Text);
                DateTime b2 = DateTime.Now;
                int res = DateTime.Compare(b1, b2);
                tienthu c = new tienthu(a.Id,dateTimePicker1.Value.ToString("yyyy-MM-dd"),int.Parse(textBox3.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
                BLL.addtienthu(c);
                dataGridView1.DataSource = BLL.getalltienthu(a.Id);
                dataGridView1.Refresh();
                dataGridView1.Update();
                if(res <=0)
                {
                    a.Salary = a.Salary + s1;
                    BLL.updatestu(a);
                }
                textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text = "0"; textBox6.Text = "0";
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không hợp lệ");
            }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Dữ liệu không được để trống");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            int s1 = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text));
            this.hh = BLL.GetTienthu(a.Id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            int s2 = hh.Phucap + hh.Dautu + hh.Luongphu + hh.Luong + hh.Thuong + hh.Tam;
            if (s1 > 10000)
            {
                DateTime b1 = DateTime.Parse(dateTimePicker1.Text);
                DateTime b2 = DateTime.Now;
                int res = DateTime.Compare(b1, b2);
                tienthu c = new tienthu(a.Id, dateTimePicker1.Value.ToString("yyyy-MM-dd"), int.Parse(textBox3.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
                BLL.updatett(c);
                if (res <= 0) 
                {
                    int b = a.Salary + s1 - s2;
                    a.Salary = b;
                    BLL.updatestu(a);
                }
                this.hh = BLL.GetTienthu(a.Id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                dataGridView1.DataSource = BLL.getalltienthu(a.Id);
                dataGridView1.Refresh();
                dataGridView1.Update();
                textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text = "0"; textBox6.Text = "0";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không được để trống");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.hh = BLL.GetTienthu(a.Id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            BLL.deltt(hh);
            int s2 = hh.Phucap + hh.Dautu + hh.Luongphu + hh.Luong + hh.Thuong + hh.Tam;
            dataGridView1.DataSource = BLL.getalltienthu(a.Id);
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
