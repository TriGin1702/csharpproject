using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgk
{
    public class chitieu
    {
        string date;
        string id;
        int doan, quanao, dilai, mypham, giaoduc, tiennha, giaoluu, yte, other;
        public chitieu(string id, int doan, int quanao, int dilai, int mypham, int yte, int giaoluu, int tiennha, int giaoduc, int other)
        {
            this.id = id;
            this.doan = doan;
            this.quanao = quanao;
            this.dilai = dilai;
            this.mypham = mypham;
            this.giaoduc = giaoduc;
            this.tiennha = tiennha;
            this.giaoluu = giaoluu;
            this.yte = yte;
            this.other= other;
            this.date = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public chitieu(string id, int doan, int quanao, int dilai, int mypham, int yte, int giaoluu, int tiennha, int giaoduc ,string d, int other)
        {
            this.id = id;
            this.doan = doan;
            this.quanao = quanao;
            this.dilai = dilai;
            this.mypham = mypham;
            this.giaoduc = giaoduc;
            this.tiennha = tiennha;
            this.giaoluu = giaoluu;
            this.yte = yte;
            this.other = other;
            this.date = d;

        }
        public chitieu(string id)
        {
            this.id = id;
            this.doan = 0;
            this.quanao = 0;
            this.dilai = 0;
            this.mypham = 0;
            this.giaoduc = 0;
            this.tiennha = 0;
            this.giaoluu = 0;
            this.yte = 0;
            this.other =0;
            this.date = DateTime.Now.ToString("yyyy-MM-dd"); ;
        }
        public chitieu(string id, string date)
        {
            this.id = id;
            this.doan = 0;
            this.quanao = 0;
            this.dilai = 0;
            this.mypham = 0;
            this.giaoduc = 0;
            this.tiennha = 0;
            this.giaoluu = 0;
            this.yte = 0;
            this.other = 0;
            this.date = date;
        }
        public string Id { get { return this.id; } set { this.id = value; } }
        public int Doan { get { return this.doan; } set { this.doan = value; } }
        public int Quanao { get { return this.quanao; } set { this.quanao = value; } }
        public int Dilai
        {
            get { return this.dilai; }
            set { this.dilai = value; }
        }
        public int Mypham
        {
            get { return this.mypham; }
            set { this.mypham = value; }
        }
        public int Giaoduc
        {
            get { return this.giaoduc; }
            set { this.mypham = value; }
        }
        public int Tiennha
        {
            get { return this.tiennha; }
            set { this.tiennha = value; }
        }
        public int Giaoluu
        {
            get { return this.giaoluu; }
            set { this.giaoluu = value; }
        }
        public int Yte
        {
            get { return this.yte; }
            set { this.yte = value; }
        }
        public string D
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public int Other
        {
            get { return this.other; }
            set { this.other = value; }
        }
    }
}


