using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ktgk;
using ktgt.Properties;

namespace ktgt
{
    public partial class Form2 : Form
    {
        string id;
        BLL BLL = new BLL();
        public Form2(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.searchchitieu(id);
            chitieu c = BLL.getchitieu(id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            double s = c.Doan + c.Quanao + c.Dilai + c.Giaoluu + c.Mypham + c.Tiennha + c.Yte + c.Giaoduc + c.Other;
            chart1.Series["chitieu"].Points.AddXY("Ăn uống", (double)Math.Round(c.Doan * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Quần áo", (double)Math.Round(c.Quanao * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Đi lại", (double)Math.Round(c.Dilai * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Giao lưu", (double)Math.Round(c.Giaoluu * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Mỹ phẩm", (double)Math.Round(c.Mypham * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Giáo dục", (double)Math.Round(c.Giaoduc * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Tiền nhà", (double)Math.Round(c.Tiennha * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Y tế", (double)Math.Round(c.Yte * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Việc khác", (double)Math.Round(c.Other * 100 / s));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form6(id).ShowDialog();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chitieu c = BLL.getchitieu(id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            double s = c.Doan + c.Quanao + c.Dilai + c.Giaoluu + c.Mypham + c.Tiennha + c.Yte + c.Giaoduc + c.Other;
            chart1.Series["chitieu"].Points.Clear();
            chart1.Series["chitieu"].Points.AddXY("Ăn uống", (double)Math.Round(c.Doan * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Quần áo", (double)Math.Round(c.Quanao * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Đi lại", (double)Math.Round(c.Dilai * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Giao lưu", (double)Math.Round(c.Giaoluu * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Mỹ phẩm", (double)Math.Round(c.Mypham * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Giáo dục", (double)Math.Round(c.Giaoduc * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Tiền nhà", (double)Math.Round(c.Tiennha * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Y tế", (double)Math.Round(c.Yte * 100 / s));
            chart1.Series["chitieu"].Points.AddXY("Việc khác", (double)Math.Round(c.Other * 100 / s));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

    }
}
