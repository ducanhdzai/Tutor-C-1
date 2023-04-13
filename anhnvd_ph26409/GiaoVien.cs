using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anhnvd_ph26409
{
    internal class GiaoVien
    {
        int iD;
        string ten;
        double soGioDay;

        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }
        public GiaoVien()
        {
            
        }

        public GiaoVien(int iD, string ten, double soGioDay)
        {
            ID = iD;
            Ten = ten;
            SoGioDay = soGioDay;
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {iD}");
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Số giờ dạy: {soGioDay}");
        }
    }
}
