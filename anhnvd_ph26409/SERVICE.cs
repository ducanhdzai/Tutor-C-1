using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anhnvd_ph26409
{
    internal class SERVICE
    {
        List<GiaoVien> lstGv = new List<GiaoVien>();
        public SERVICE() { }
        public void NhapThongTin()
        {
            string nhapLai;
            do
            {
                GiaoVien gv = new GiaoVien();
                Console.Write("Mời bạn nhập ID: ");
                gv.ID = Convert.ToInt32(Console.ReadLine());
                if (!CheckID(gv.ID)) // Check xem mã đã tồn tại hay chưa nế mà chưa thì mới cho nhập những thứ tiếp theo
                {
                    Console.WriteLine("Mã bạn nhập đã tồn tại.");

                }
                else
                {
                    Console.Write("Mời bạn nhập tên giáo viên: ");
                    gv.Ten = Console.ReadLine();
                    Console.Write("Mời bạn nhập số giờ dạy: ");
                    gv.SoGioDay = Convert.ToDouble(Console.ReadLine());
                    lstGv.Add(gv);
                }               
                Console.WriteLine("Bạn có muốn nhập tiếp hay không");
                Console.WriteLine("Phím bất kì:Có      N: Không");
                nhapLai = Console.ReadLine();
            } while (nhapLai.ToLower() != "n");
        }
        public bool CheckID(int idCheck)
        {
            int dem = 0; // giá trị ban đầu
            foreach (GiaoVien gv in lstGv)
            {
                if (gv.ID == idCheck)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void XuatDanhSachDoiTuong()
        {
            foreach (GiaoVien gv in lstGv)
            {
                gv.InThongTin();
            }
        }
        public void XuatDanhSachDoiTuong(double gioBatDau, double gioKetThuc)
        {
            foreach (GiaoVien gv in lstGv)
            {
                if (gv.SoGioDay >= gioBatDau && gv.SoGioDay <= gioKetThuc)
                {
                    gv.InThongTin();
                }
            }
        }
        public void XoaDoiTuongTheoID()
        {
            Console.Write("Mời bạn nhập ID GV cần xóa: ");
            int idXoa = Convert.ToInt32(Console.ReadLine());
            //foreach (GiaoVien gv in lstGv)
            //{
            //    if (gv.ID == idXoa)
            //    {
            //        lstGv.Remove(gv);
            //        break;// Phải thêm break nếu k chạy foreach sẽ lỗi
            //    }
            //}
            // Hoặc cách 2
            for (int i = 0; i < lstGv.Count; i++)
            {
                if (lstGv[i].ID == idXoa)
                {
                    lstGv.Remove(lstGv[i]);
                }
            }
        }
        public void SuaDoiTuong()
        {
            Console.Write("Mời bạn nhập ID GV cần sửa: ");
            int idSua = Convert.ToInt32(Console.ReadLine());
            foreach (GiaoVien gv in lstGv)
            {
                if (gv.ID == idSua)
                {
                    Console.WriteLine("Thông tin cũ");
                    gv.InThongTin(); 
                    Console.WriteLine("Mời bạn cập nhật thông tin: ");
                    Console.Write("Mời bạn nhập tên giáo viên: ");
                  /*Dũng cũ */  gv.Ten = Console.ReadLine(); /*VD: Khánh*/
                    Console.Write("Mời bạn nhập số giờ dạy: ");
                    gv.SoGioDay = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public void KeThua()
        {
            GiaoVienPoly giaoVienPoly = new GiaoVienPoly();
            Console.Write("Mời bạn nhập ID: ");
            giaoVienPoly.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập tên giáo viên: ");
            giaoVienPoly.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập số giờ dạy: ");
            giaoVienPoly.SoGioDay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mời bạn nhập ngành dạy: ");
            giaoVienPoly.NganhDay = Console.ReadLine();
            giaoVienPoly.InThongTin();
        }

        }
}
