using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstExercise
{
    public class PersonDao
    {
        DBConnection dbConnection = new DBConnection();
        string role;
        public PersonDao() 
        {
            if (this is HocSinhDao)
                role = "HocSinh";
            else
                role = "GiangVien";
        }

        public void Them(Person ps)
        {
            string sqlStr = string.Format("INSERT INTO "+ role + "(ID, Ten, Diachi, Cmnd, NgayThangNamSinh, GioiTinh, Phone, Email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                    , ps.Id, ps.Ten, ps.DiaChi, ps.Cmnd, ps.NgayThangNamSinh.ToShortDateString(), ps.GioiTinh, ps.Phone, ps.Email);
            dbConnection.ThucThi(sqlStr);
        }

        public void Xoa(int textid)
        {
            string sqlStr = string.Format("DELETE FROM " + role + " WHERE ID = '{0}'", textid);
            dbConnection.ThucThi(sqlStr);
        }

        public void Sua(Person ps)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', CMND = '{2}', NgayThangNamSinh = '{3}', GioiTinh = '{4}', Phone = '{5}', Email = '{6}' WHERE ID = '{7}'"
                    , ps.Ten, ps.DiaChi, ps.Cmnd, ps.NgayThangNamSinh.ToShortDateString(), ps.GioiTinh, ps.Phone, ps.Email, ps.Id);
            dbConnection.ThucThi(sqlStr);
        }
    }
}