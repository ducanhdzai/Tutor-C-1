using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class Program
    {
        static void Menu()
        {
            int choice;
            QLDV qLDV = new QLDV();
            do
            {
                Console.WriteLine("------------ Menu ------------");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách các ID đối tượng có mã lẻ");
                Console.WriteLine("4.Tìm đối tượng có mã bắt đầu bởi 1 chuỗi ký tự nhập từ bàn phím");
                Console.WriteLine("5. Sắp xếp giảm dần danh sách Động vật theo ID.");
                Console.WriteLine("6.Kế thừa ");
                Console.WriteLine("0.Thoát ");
                Console.WriteLine("Mời bạn chọn chức năng");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            qLDV.NhapThongTin("Welcome to Chuc nang 1");
                            break;
                        }
                    case 2:
                        {

                            qLDV.XuatDanhSachDoiTuong();
                            break;
                        }
                    case 3:
                        {
                            qLDV.XuatDanhSachDoiTuongCoMaLe();
                            break;
                        }
                    case 4:
                        {
                            qLDV.TimKiemBoiChuoiBatDau();
                            break;
                        }
                    case 5:
                        {
                            qLDV.SapXepGiamDan();
                            break;
                        }
                    case 6:
                        {
                            qLDV.KeThua();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!!!");
                            break;
                        }
                    default:
                        Console.WriteLine("Chức năng bạn nhập không tồn tại. Vui lòng chọn chức năng từ 1-6");
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
            Console.ReadKey();
        }
    }
}
