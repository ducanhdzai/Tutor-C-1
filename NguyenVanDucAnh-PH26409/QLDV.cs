using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class QLDV
    {
        List<DongVat> lstDV = new List<DongVat>();
        public QLDV()
        {
        }
        public void NhapThongTin(string title)
        {
            string choiceAgain;
            Console.WriteLine(title);
            do
            {
                DongVat dv = new DongVat();
                Console.WriteLine("Mời bạn nhập ID: ");
                dv.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Mã DV: ");
                dv.MaDV = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập thể loại: ");
                dv.TheLoai = Console.ReadLine();
                lstDV.Add(dv);
                Console.WriteLine("Bạn có muốn nhập tiếp hay không?");
                Console.WriteLine("Phím bất kì: Có          N:Không");
                choiceAgain = Console.ReadLine();
            } while (choiceAgain.ToUpper() != "N");
            //5 điểm 10p
        }
        public void XuatDanhSachDoiTuong()
        {
            foreach (DongVat dongVat in lstDV)
            {
                dongVat.InThongTin();
            }
        }
        public void XuatDanhSachDoiTuongCoMaLe()
        {
            foreach (DongVat dongVat in lstDV)
            {
                if (dongVat.ID % 2 == 1)
                {
                    dongVat.InThongTin();
                }
            }
        }
        public void TimKiemBoiChuoiBatDau()
        {
            Console.Write("Mời bạn nhập chuỗi cần tìm kiếm: ");
            string chuoiTimKiem = Console.ReadLine();
            foreach (DongVat dongVat in lstDV)
            {
                if (dongVat.MaDV.StartsWith(chuoiTimKiem.ToUpper()) || dongVat.MaDV.StartsWith(chuoiTimKiem.ToLower()))
                {
                    dongVat.InThongTin();
                }
            }
        }
        public void SapXepGiamDan()
        {
            lstDV = lstDV.OrderByDescending(x => x.ID).ToList();// SX giảm dần
            foreach (DongVat dongVat in lstDV)
            {
                dongVat.InThongTin();
            }
        }
        public void KeThua()
        {
            Meo meo2 = new Meo(1,"2","2","2",2);
            Meo meo = new Meo();
            Console.WriteLine("Mời bạn nhập ID: ");
            meo.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập Mã DV: ");
            meo.MaDV = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập thể loại: ");
            meo.TheLoai = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tên: ");
            meo.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập cân nặng: ");
            meo.CanNang = Convert.ToSingle(Console.ReadLine());
            meo.InThongTin();
        }
    }
}

