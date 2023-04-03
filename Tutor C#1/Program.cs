using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_C_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Ôn tập IF-ELSE, SWITCh CASE
            // printf("hello WORLD");
            //Console.WriteLine("Hello World!");// Viết xuống dòng
            //Console.Write("Hello World!");// Viết trên 1 dòng
            // Nhập dữ liệu từ bàn phím
            // Console.ReadLine() hoặc là Console.Read()
            // Mặc định kiểu dữ liệu kiểu string
            //Console.WriteLine("Mời bạn nhập 1 thứ gì đó");
            //string hello = Console.ReadLine();
            //// Cách để ghi nhanh cw + tab
            //Console.WriteLine(hello);
            // Tương tự nếu muốn nhập kiểu dữ liệu khác thì 
            // phải ép kiểu
            // int, float, double,...
            //Console.WriteLine("Mời bạn nhập điểm C#1:");
            //int diem = Convert.ToInt32(Console.ReadLine());// Mặc định = 0
            // Int32.Parse(Console.ReadLine()) báo lỗi
            // float - Convert.ToSingle(Console.ReadLine());
            // double - Convert.ToDouble(Console.ReadLine());
            // Lý thuyết.
            // IF ELSE - Nếu thì ngược lại thì còn lại
            //if (diem > 8 && diem < 10) // Giả dụ nhập 100 thì ?
            //{
            //    Console.WriteLine("Bạn thật giỏi, hãy cố gắng hơn nhé");
            //}
            //else if(diem > 0 && diem <= 8)
            //{
            //    Console.WriteLine("Hãy cố gắng lên bạn sắp làm được rồi");
            //}
            //else
            //{
            //    Console.WriteLine("Điểm bạn nhập sai sai");
            //}
            //Console.WriteLine("Mời bạn chọn chức năng");
            //int chon = Convert.ToInt32(Console.ReadLine());
            //switch (chon)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine($"Bạn vừa chọn số {chon}");
            //            Console.WriteLine("Bạn vừa chọn số {0}",chon);
            //            Console.WriteLine("Bạn vừa chọn số "+chon);
            //            // có 3 cách để truyền biến số vào câu lệnh in màn hình
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Chức năng số 2 thật nhàm chán");
            //            break;
            //        }
            //    default:// Mặc định
            //        Console.WriteLine("Bạn nhập cái gì dạ?");
            //        break;
            //}
            // Bài tập tìm số lớn với số bé nhập từ bàn phím
            // dùng gì ta?
            //Console.WriteLine("Mời bạn nhập số a: ");
            //int soA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mời bạn nhập số b: ");
            //int soB = Convert.ToInt32(Console.ReadLine());
            //if (soA > soB)
            //{
            //    Console.WriteLine($"Số {soA} là số lớn");
            //    Console.WriteLine($"Số {soB} là số bé");
            //}
            //else
            //{
            //    Console.WriteLine($"Số {soB} là số lớn");
            //    Console.WriteLine($"Số {soA} là số bé");
            //}
            // Kiểm tra số chẵn lẻ
            //Console.WriteLine("Mời bạn nhập số cần kiểm tra");
            //int kiemTraSo = Convert.ToInt32(Console.ReadLine());
            //if (kiemTraSo % 2 == 0)
            //{
            //    Console.WriteLine("Đây chính xác là chẵn");
            //}
            //else
            //{
            //    Console.WriteLine("Đây chính xác là lẻ");
            //}
            // Nhập vào từ bàn phím tìm ra số ngày của tháng đấy
            //Console.WriteLine("Mời bạn nhập vào tháng cần kiểm tra");
            int kiemTraThang = Convert.ToInt32(Console.ReadLine());
            switch (kiemTraThang)
            {
                case 1:
                    {
                        Console.WriteLine("Tháng của 1 của bạn có 31 ngày");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Mời bạn nhập thêm năm");
                        int nam = Convert.ToInt32(Console.ReadLine());
                        if (nam % 400 == 0 || nam % 4 == 0 && nam % 100 != 0)
                        {
                            Console.WriteLine("Tháng 2 của bạn có 29 ngày");
                        }
                        else
                        {
                            Console.WriteLine("Tháng 2 của bạn có 28 ngày");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tháng của 3 của bạn có 31 ngày");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tháng của 4 của bạn có 30 ngày");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Tháng của 5 của bạn có 31 ngày");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Tháng của 6 của bạn có 30 ngày");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Tháng của 7 của bạn có 31 ngày");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Tháng của 8 của bạn có 31 ngày");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Tháng của 9 của bạn có 30 ngày");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Tháng của 10 của bạn có 31 ngày");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Tháng của 11 của bạn có 30 ngày");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Tháng của 12 của bạn có 31 ngày");
                        break;
                    }
                default:
                    Console.WriteLine("Tháng này có tồn tại à?");
                    break;
            }

            //int chonChucNang;
            //do
            //{
            //    Console.WriteLine("Mời bạn chọn chức năng: ");
            //    chonChucNang = Convert.ToInt32(Console.ReadLine());
            //    switch (chonChucNang)
            //    {
            //        case 0:
            //            {
            //                Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình của mình");
            //                break;
            //            }
            //        default:
            //            Console.WriteLine("Chức năng bạn nhập không tồn tại");
            //            break;
            //    }
            //} while (chonChucNang != 0);

            Console.WriteLine("Mời bạn nhập ngày: ");
            int ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập tháng");
            int thang = Convert.ToInt32(Console.ReadLine());
            switch (thang)
            {
                case 1:
                    {

                        if (ngay == 31)
                        {
                            Console.WriteLine($"Ngày tiếp theo là mùng 1 tháng {thang+1}");
                        }
                        else if(ngay > 0 && ngay < 31)
                        {
                            Console.WriteLine($"Ngày tiếp theo là {ngay+1} tháng {thang}");
                        }
                        else
                        {
                            Console.WriteLine("Ngày không hợp lệ");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Mời bạn nhập thêm năm");
                        int nam = Convert.ToInt32(Console.ReadLine());
                        if (nam % 400 == 0 || nam % 4 == 0 && nam % 100 != 0)
                        {
                            Console.WriteLine("Tháng 2 của bạn có 29 ngày");
                        }
                        else
                        {
                            Console.WriteLine("Tháng 2 của bạn có 28 ngày");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tháng của 3 của bạn có 31 ngày");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tháng của 4 của bạn có 30 ngày");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Tháng của 5 của bạn có 31 ngày");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Tháng của 6 của bạn có 30 ngày");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Tháng của 7 của bạn có 31 ngày");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Tháng của 8 của bạn có 31 ngày");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Tháng của 9 của bạn có 30 ngày");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Tháng của 10 của bạn có 31 ngày");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Tháng của 11 của bạn có 30 ngày");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Tháng của 12 của bạn có 31 ngày");
                        break;
                    }
                default:
                    Console.WriteLine("Tháng này có tồn tại à?");
                    break;
            }
            Console.ReadKey();// Để dừng chương trình
        }
    }
}
