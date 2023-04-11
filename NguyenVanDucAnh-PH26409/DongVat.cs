using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class DongVat
    {
        int iD;
        string maDV;
        string theLoai;

        public int ID { get => iD; set => iD = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }

        public DongVat()
        {
            
        }

        public DongVat(int iD, string maDV, string theLoai)
        {
            ID = iD;
            MaDV = maDV;
            TheLoai = theLoai;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {iD}");
            Console.WriteLine($"Mã DV: {maDV}");
            Console.WriteLine($"Thể loại: {theLoai}");
        }
        //2-3p 
    }
}
