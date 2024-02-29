using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstExercise
{
    public class GiangVien : Person
    {
        public GiangVien(int id, string ten, string diaChi, string cmnd, DateTime ngayThangNamSinh, string gioiTinh, string phone, string email) : base(id, ten, diaChi, cmnd, ngayThangNamSinh, gioiTinh, phone, email)
        {

        }
    }
}