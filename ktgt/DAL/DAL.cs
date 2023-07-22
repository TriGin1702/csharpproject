using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using ktgt.DTO;

namespace ktgk
{
    public class DAL
    {
        MySqlConnection con = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=;database = qlchitieu");
        public DataTable searchchitieu(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select ngay,Doan,Quanao,Dilai,Mypham,Yte,Giaoluu,Tiennha,Giaoduc,other from chitieu where id = '" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getalltienthu(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from tienthu where id = '" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool addchitieu(chitieu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("insert into chitieu(id,Doan,Quanao,Dilai,Mypham,Yte,Giaoluu,Tiennha,Giaoduc,ngay,other) values('" + c.Id + "','" + c.Doan + "','" + c.Quanao + "','" + c.Dilai + "','" + c.Mypham + "','" + c.Yte + "','" + c.Giaoluu + "','" + c.Tiennha + "','" + c.Giaoduc + "','" + c.D + "','"+c.Other+"')");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool addtienthu(tienthu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("insert into tienthu(id,ngay,luong,phucap,thuong,luongphu,dautu,tam) values('" + c.Id + "','" + c.Date+ "','" + c.Luong + "','" + c.Phucap + "','" + c.Thuong + "','" + c.Luongphu + "','" + c.Dautu + "', '"+c.Tam+"')");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thất bại");
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool addstudent(student stu)
        {
            try
            {
                con.Open();
                string mysql = string.Format("insert into student(id,name,tk,mk,age,salary) values ('"+ stu.Id +"','"+ stu.Name +"','"+ stu.Tk +"','"+ stu.Mk +"','"+ stu.Age +"','"+ stu.Salary +"')");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                chitieu c = new chitieu(stu.Id);
                string mysql2 = string.Format("insert into chitieu(id,Doan,Quanao,Dilai,Mypham,Yte,Giaoluu,Tiennha,Giaoduc,ngay,other) values('" + c.Id + "','" + c.Doan + "','" + c.Quanao + "','" + c.Dilai + "','" + c.Mypham + "','" + c.Yte + "','" + c.Giaoluu + "','" + c.Tiennha + "','" + c.Giaoduc + "','" + c.D + "','"+c.Other+"')");
                MySqlCommand cmd2 = new MySqlCommand(mysql2, con);
                if (cmd.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool updatect(chitieu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("update chitieu set Doan ='"+c.Doan+"', Quanao = '"+c.Quanao+"' , Dilai = '"+c.Dilai+"', Mypham = '"+c.Mypham+"', Yte = '"+c.Yte+"', Giaoluu = '"+c.Giaoluu+"', Tiennha = '"+c.Tiennha+"', Giaoduc = '"+c.Giaoduc+"' where id = '"+c.Id+"' and ngay ='"+c.D+"'");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool updatett(tienthu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("update tienthu set luong ='" + c.Luong + "', phucap = '" + c.Phucap + "' , thuong = '" + c.Thuong + "', luongphu = '" + c.Luongphu + "', dautu = '" + c.Dautu + "', tam = '" + c.Tam + "' where id = '"+c.Id+"' and ngay = '"+c.Date+"'");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool deltt(tienthu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("delete from tienthu where id = '"+c.Id+"' and ngay = '"+c.Date+"' ");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    return true;
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại");
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool delct(chitieu c)
        {
            try
            {
                con.Open();
                string mysql = string.Format("delete from chitieu where id = '" + c.Id + "' and ngay = '" + c.D + "' ");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool updatestu(student stu)
        {
            try
            {
                con.Open();
                string mysql = string.Format("update student set name ='" + stu.Name + "',tk='" + stu.Tk + "',mk = '" + stu.Mk + "',age = '" + stu.Age + "', salary = '" + stu.Salary + "' where id = '" + stu.Id + "'");
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public student checkTK(string tk, string mk)
        {
            student a = new student("no", "", tk, mk, 18, 0);
            try
            {
                con.Open();
                string query = string.Format("select * from student where tk = '" + tk + "'and mk= '" + mk + "'");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new student(dr.GetString(0), dr.GetString(1), tk, mk, dr.GetInt32(4), dr.GetInt32(5));
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
            return a;
        }
        public student getstubyid(string id)
        {
            student a = new student("no", "", "", "", 18, 0);
            try
            {
                con.Open();
                string query = string.Format("select * from student where id = '" + id + "'");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new student(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5));
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
            return a;
        }
        public chitieu checkchitieu(string id)
        {
            chitieu a = new chitieu(id);
            try
            {
                con.Open();
                string query = string.Format("select * from chitieu where id = '" + id + "' and ngay = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' ");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new chitieu(id, dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7), DateTime.Now.ToString("yyyy--MM-dd"), dr.GetInt32(10));
                }
                dr.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("loi he thong");
            }
            finally
            {
                con.Close();
            }
            return a;
        }
        public tienthu checktienthu(string id)
        {
            tienthu a = new tienthu(id, DateTime.Now.ToString("yyyy-MM-dd"));
            try
            {
                con.Open();
                string query = string.Format("select * from tienthu where id = '" + id + "' and ngay = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new tienthu(id,DateTime.Now.ToString("yyyy-MM-dd"),dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7));
                }
            }
            catch(Exception ex) { }
            finally { con.Close(); }
            return a;
        }
        public chitieu getchitieu(string id, string date ) {
            chitieu a = new chitieu(id);
            try
            {
                con.Open();
                string query = string.Format("select * from chitieu where id = '" + id + "' and ngay = '" + date + "' ");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new chitieu(id, dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7), date, dr.GetInt32(10));
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
            return a;
        }
        public tienthu GetTienthu(string id , string date)
        {
            tienthu a = new tienthu(id,date);
            try
            {
                con.Open();
                string mysql = "select * from tienthu where id = '"+ id+ "' and  ngay = '"+date+"'";
                MySqlCommand command = new MySqlCommand(mysql, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    a = new tienthu(id,date,dr.GetInt32(2),dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7));
                }
            }
            catch (Exception ex) { MessageBox.Show("lỗi hệ thống"); }
            finally { con.Close(); }
            return a;
        }
        public student capnhat(student a) 
        {
            try
            {
                con.Open();
                string query = string.Format("select * from tienthu where id = '" +a.Id + "'");
                MySqlCommand command = new MySqlCommand(query, con);
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DateTime b1 = DateTime.Parse(dr["ngay"].ToString());
                        DateTime b2 = DateTime.Now;
                        int res = DateTime.Compare(b1, b2);
                        if (res <= 0) {
                            a.Salary += dr.GetInt32(2)+ dr.GetInt32(3) + dr.GetInt32(4) + dr.GetInt32(5) + dr.GetInt32(6) + dr.GetInt32(7);
                        }
                    }
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
            return a;
        }
    }
}