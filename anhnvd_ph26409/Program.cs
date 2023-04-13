using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anhnvd_ph26409
{
    internal class Program
    {
        static void Menu()
        {
            int choice;
            SERVICE sv = new SERVICE();
            do
            {
                Console.WriteLine("-------- Menu --------  ");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách đối tượng theo khoảng");
                Console.WriteLine("4.Xóa đối tượng theo ID");
                Console.WriteLine("5.Kế thừa");      
                Console.WriteLine("6.Sửa");
                Console.WriteLine("0.Thoát");
                Console.Write("Mời bạn chọn chức năng: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            sv.NhapThongTin();
                            break;
                        }    
                    case 2:
                        {
                            sv.XuatDanhSachDoiTuong();
                            break;
                        }               
                    case 3:
                        {
                            Console.Write("Mời bạn nhập giờ bắt đầu: ");
                            double gioBatDau = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Mời bạn nhập giờ kết thúc: ");
                            double gioKetThuc = Convert.ToDouble(Console.ReadLine());
                            sv.XuatDanhSachDoiTuong(gioBatDau, gioKetThuc);
                            break;
                        }                  
                    case 4:
                        {
                            sv.XoaDoiTuongTheoID();
                            break;
                        }
                    case 5:
                        {
                            sv.KeThua();
                            break;
                        }
                    case 6:
                        {
                            sv.SuaDoiTuong();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Hẹn gặp lại");
                            break;
                        }
                    default:
                        Console.WriteLine("Chức năng bạn nhập không có vui lòng chọn lại");
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
