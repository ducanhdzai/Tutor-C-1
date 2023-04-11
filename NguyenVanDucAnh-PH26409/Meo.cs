using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class Meo: DongVat
    {
        string ten;
        float canNang;

        public string Ten { get => ten; set => ten = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public Meo()
        {
            
        }

        public Meo(int iD, string maDV, string theLoai, string ten,
        float canNang) : base(iD, maDV, theLoai)
        {
            Ten = ten;
            CanNang = canNang;
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Cân nặng: {canNang}");
        }
    }
}
