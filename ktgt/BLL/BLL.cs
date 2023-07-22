using ktgk;
using ktgt.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgt
{
    public class BLL
    {
        DAL dal = new DAL();
        public DataTable searchchitieu(string id)
        {
            return dal.searchchitieu(id);
        }
        public bool addchitieu(chitieu c) { return dal.addchitieu(c); }
        public bool addstudent(student stu) { return dal.addstudent(stu); }
        public bool updatect(chitieu c) { return dal.updatect(c); }
        public bool updatestu(student stu) { return dal.updatestu(stu); }
        public student checkTK(string tk, string mk) { return dal.checkTK(tk, mk); }
        public student getstubyid(string id) { return dal.getstubyid(id); }
        public chitieu checkchitieu(string id) { return dal.checkchitieu(id); }
        public chitieu getchitieu(string id, string date) { return dal.getchitieu(id, date); }
        public DataTable getalltienthu(string id) { return dal.getalltienthu(id); }
        public bool addtienthu(tienthu c) { return dal.addtienthu(c);}
        public bool deltt(tienthu c) { return dal.deltt(c); }
        public bool updatett(tienthu c) { return dal.updatett(c);  }
        public student capnhat(student a) { return dal.capnhat(a); }
        public bool delct(chitieu c) { return dal.delct(c); }
        public tienthu checktienthu(string id) { return dal.checktienthu(id); }
        public tienthu GetTienthu(string id, string date) { return dal.GetTienthu(id, date); }
    }
}
