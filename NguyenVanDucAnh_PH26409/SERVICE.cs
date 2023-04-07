using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class SERVICE
    {
        //Code các chức năng ở đây
        List<SinhVien> lstSinhVien = new List<SinhVien>(); // Khởi tạo 1 list Sinh Viên list sinh viên này sẽ là nơi để nhập xuất thông tin v...v..
        public SERVICE()
        {
        }
        public void NhapThongTin()
        {
            string nhapLai;
            do
            {
                // Khởi tạo ra 1 thằng sinh viên để thêm vào list
                SinhVien sv = new SinhVien();// đây gọi là hành động khởi tạo 1 đối tượng
                // Nhập thông tin cho đối tượng
                Console.WriteLine("Mời bạn nhập MSV: ");
                sv.MaSV = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập họ và tên: ");
                sv.HoTen = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                // Thêm sinh viên vào list
                lstSinhVien.Add(sv);
                // Đã thêm vào list
                // Hỏi có nhập lại hay không
                Console.WriteLine("Bạn có muốn nhập thêm hay không?");
                Console.WriteLine("Phím bất kì: Có      N: Không");
                nhapLai = Console.ReadLine();
            } while (nhapLai.ToUpper() != "N"); // To lower là chuyển tất cả thành chữ thường
            // To Upper là chuyển tất cả các chữ thành chữ in Hoa
        }
        public void XuatThongTin()
        {
            // Đây là nơi mà xuất ra các thông tin
            foreach (SinhVien sv in lstSinhVien)
            {
                sv.inThongTin();
            }
            //Sau đó sang bên Program để gọi chức năng
        }
    }
}
