using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Tutor_C_1
{
    internal class Child : ConNguoi
    {
        // Khi kế thừa những gì ở ConNguoi sẽ được bê sang 
        string queQuan;
        public Child()
        {
            
        }

        public Child(string ten, int tuoi, float canNang, float chieuCao, string gioiTinh, string queQuan) : base(ten, tuoi, canNang, chieuCao, gioiTinh)
        {
            QueQuan = queQuan;
        }

        public string QueQuan { get => queQuan; set => queQuan = value; }

        // Trong class con
        public override void InThongTin()
        {
            base.InThongTin();
            // base.InThongTin()
            //Console.WriteLine($"Tên {ten}");
            //Console.WriteLine($"Tuổi {tuoi}");
            //Console.WriteLine($"Cân nặng {canNang}");
            //Console.WriteLine($"Chiều cao {chieuCao}");
            //Console.WriteLine($"Giới tính {gioiTinh}");
            Console.WriteLine($"Quê quán {queQuan}");
        }
    }
}
