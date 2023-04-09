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
                sv.MaSV = MaTuSinh();
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
        // Nếu kh dùng linq dùng thuần 
        // Lấy ra tên 
        // Lấy kí tự đầu tiên của tên xong check xem có == "A"
        public void TimKiemTenKiTuACach1()
        {
            foreach (SinhVien sv in lstSinhVien)
            {
                if (sv.HoTen[0] == 'A') // Lấy ra kí tự đầu tiên của ho tên bằng cách là [0] bởi vì hoTen là 1 mảng kí tự
                {
                    sv.inThongTin();
                }
            }
        }
        public void TimKiemTenKiTuACach2()
        {
            foreach (SinhVien sv in lstSinhVien)
            {
                #region StartsWith
                // Start with là để tìm kiếm chuỗi bắt đầu bởi chuỗi ở bên trong StartsWith("") trong bài này là tìm kiếm Sinh Viên có họ tên bắt đầu bằng chữ A. Và chỉ có thể sử dụng khi thuộc tính là string nếu tìm được thằng nào bắt đầu bằng chữ A thì sẽ trả về giá true cho if và câu lệnh ở trong if sẽ được thực hiện
                #endregion
                if (sv.HoTen.StartsWith("A"))
                {
                    sv.inThongTin();
                }
            }
        }
        public void XuatThongTinSinhVienTuoiTren20()
        {
            foreach (SinhVien sv in lstSinhVien)
            {
                if (DateTime.Now.Year - sv.NamSinh > 20) //DateTime.Now là lấy ra toàn bộ thời gian hiện tại khi chạy đến câu if này cả là giây phút giờ thêm .Year vào để chỉ lấy ra năm thôi.
                {
                    sv.inThongTin();
                }
            }
        }
        // Tạo ra phương thức trả về có giá trị
        // Làm mã tự sinh
        public string MaTuSinh()
        {
// nếu kiểu dữ liệu của mã sv là int thì ko cần cộng chuỗi và ở trên là public int
                return "MSV" + lstSinhVien.Count();
        }
    }
}
