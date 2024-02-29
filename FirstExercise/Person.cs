using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FirstExercise
{
    public class Person
    {
        private int id;
        private string ten;
        private string diaChi;
        private string cmnd;
        private DateTime ngayThangNamSinh;
        private string gioiTinh;
        private string phone;
        private string email;

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime NgayThangNamSinh { get => ngayThangNamSinh; set => ngayThangNamSinh = value; }
        public int Id { get => id; set => id = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public Person(int id, string ten, string diaChi, string cmnd, DateTime ngayThangNamSinh, string gioiTinh, string phone, string email)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.ngayThangNamSinh = ngayThangNamSinh;
            this.id = id;
            this.gioiTinh = gioiTinh;
            this.phone = phone;
            this.email = email;
        }

        public bool checkMailPhoneNull()
        {
            if (String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(diaChi) || String.IsNullOrEmpty(id.ToString()) || String.IsNullOrEmpty(gioiTinh) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui long dien day du du lieu");
                return false;
            }

            string strRegexMail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex regexMail = new Regex(strRegexMail);
            if (regexMail.IsMatch(email) == false)
            {
                MessageBox.Show("Email khong hop le! Vui long nhap lai");
                return false;
            }

            string strRegexPhone = @"^([\+]?84[-]?|[0])?[1-9][0-9]{8}$";
            Regex regexPhone = new Regex(strRegexPhone);
            if (regexPhone.IsMatch(phone) == false)
            {
                MessageBox.Show("So dien thoai khong dung!");
                return false;
            }

            int tuoi = DateTime.Now.Year - ngayThangNamSinh.Year;
            if (tuoi < 17)
            {
                MessageBox.Show("Ban chua du 17 tuoi!");
                return false;
            }
            return true;
        }
    }
}