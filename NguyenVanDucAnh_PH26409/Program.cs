using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class Program
    {
        // Tạo ra 1 hàm Menu
        static void Menu()
        {
            // Đây sẽ là nơi gọi các chức năng từ bên SERVICE
            // Tạo ra 1 biến để lưu số chức người dùng vừa chọn
            int choice;
            // Tạo ra 1 vòng lặp để thực hiện lại các chức năng cho đến khi người dùng chọn 0 để thoát
            // Chúng ta sẽ dùng vòng lặp do while
            //Tạo ra 1 đối tượng Service để sử dụng các chức năng
            SERVICE services = new SERVICE(); // Vừa khởi tạo
            do
            {
                Console.WriteLine("---------- Menu ----------");
                Console.WriteLine("1.Nhập 1 danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách các SV có tên bắt đầu bởi chữ A");
                Console.WriteLine("4. Chúc mừng những sinh viên có tuổi > 20");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("Mời bạn chọn chức năng");
                choice = Convert.ToInt32(Console.ReadLine());
                // Cho giá trị của người dùng nhập vào switch case để thực hiện các chức năng
                switch (choice)
                {
                    case 1:
                        {
                            services.NhapThongTin();
                        }
                        break;
                    case 2:
                        {
                            services.XuatThongTin();
                        }
                        break;
                    case 3:
                        {
                            services.TimKiemTenKiTuACach1();
                        }
                        break;
                    case 4:
                        {
                            services.XuatThongTinSinhVienTuoiTren20();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Mời bạn nhập MSV: ");
                            string msv = Console.ReadLine();
                            Console.WriteLine("Mời bạn nhập họ và tên: ");
                            string hoTen = Console.ReadLine();
                            Console.WriteLine("Mời bạn nhập năm sinh: ");
                            int namSinh = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mời bạn nhập điểm C#: ");
                            double diemCsharp = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Mời bạn nhập điểm Java: ");
                            double diemJava = Convert.ToDouble(Console.ReadLine());
                            SinhVienUDPM svUDPM = new SinhVienUDPM(msv,hoTen,namSinh,diemCsharp,diemJava); // Đây là constructor  có tham số
                            svUDPM.inThongTin();
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Bạn đã thoát chương trình. Rất cảm ơn vì đã sử dụng");
                        }
                        break;
                    default:
                        Console.WriteLine("Chức năng bạn chọn không tồn tại vui lòng chọn các chức năng có trong menu");
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Gọi đến hàm menu
            Menu();
            Console.ReadKey();
        }
    }
}
