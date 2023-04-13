using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anhnvd_ph26409
{
    internal class GiaoVienPoly:GiaoVien
    {
        string nganhDay;
        public GiaoVienPoly()
        {
            
        }

        public GiaoVienPoly(int iD, string ten, double soGioDay, string nganhDay) : base(iD, ten, soGioDay)
        {
            NganhDay = nganhDay;
        }

        public string NganhDay { get => nganhDay; set => nganhDay = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Ngành dạy: {nganhDay}");
        }
    }
}
