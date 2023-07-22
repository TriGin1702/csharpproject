using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgk
{
    public class student
    {
        string id, name, tk, mk;
        int age, salary;
        public student(string id, string name, string tk, string mk, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.tk = tk;
            this.mk = mk;
            this.age = age;
            this.salary = salary;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tk
        {
            get { return tk; }
            set { tk = value; }
        }
        public string Mk
        {
            get { return mk; }
            set { mk = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}