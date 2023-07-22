using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgt.DTO
{
    public class tienthu
    {
        string id, date;
        int luong, phucap, thuong, luongphu, dautu, tam;
        public tienthu(string id, string date, int luong, int phucap, int thuong, int luongphu, int dautu, int tam)
        {
            this.id = id;
            this.date = date;
            this.luong = luong;
            this.phucap = phucap;
            this.thuong = thuong;
            this.luongphu = luongphu;
            this.dautu = dautu;
            this.tam = tam;
        }
        public tienthu(string id, string date)
        {
            this.id = id;
            this.date = date;
            this.luong = 0;
            this.phucap = 0;
            this.thuong = 0;
            this.luongphu = 0;
            this.dautu = 0;
            this.tam = 0;
        }
        public string Id { get { return id; } set { this.id = value; } }
        public string Date { get { return date; } set { this.date = value; } }
        public int Luong { get { return luong; } set { this.luong = value; } }
        public int Phucap { get { return phucap; } set { this.phucap = value; } }
        public int Thuong { get { return thuong; } set { this.thuong = value; } }
        public int Luongphu { get { return luongphu; } set { this.luongphu = value; } }
        public int Dautu { get { return dautu; } set { this.dautu = value; } }
        public int Tam { get { return tam; } set { this.tam = value; } }
    }
}
