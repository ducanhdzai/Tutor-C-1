using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Tutor_C_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // OOP - LIST
            // Nói lại về vòng lặp
            // Vòng lặp
            //Console.WriteLine("1. Xin lỗi em lần sau anh không thế nữa.");
            //Console.WriteLine("2. Xin lỗi em lần sau anh không thế nữa.");
            //Console.WriteLine("3. Xin lỗi em lần sau anh không thế nữa.");
            //Console.WriteLine("4. Xin lỗi em lần sau anh không thế nữa.");
            //Console.WriteLine("300. Xin lỗi em lần sau anh không thế nữa.");
            // Người yêu bắt viết 300 lần
            // Mình thông minh
            // for + tab
            //for (// số khởi đầu; điều kiện; bước nhảy)
            //{

            //}
            // Khi mà có điểm bắt đầu và điểm kết thúc tức là biết số lần lặp
            // thì nên dùng for
            //for (int i = 1; i <= 300; i++)
            //{
            //    Console.WriteLine($"{i}. Xin lỗi em lần sau anh không thế nữa.");
            //}
            // while
            // Không cần điểm dừng sẽ lặp lại đến khi nào mà là false
            int j = 0;
            //while (j <= 300)
            //{
            //    Console.WriteLine($"{j}. Xin lỗi em lần sau anh không thế nữa.");
            //    j++;
            //}
            // Dùng là để làm menu khi đi thi
            // Sẽ chắc chắn thực hiện 1 lần trước khi kiểm tra điểm trong while()
            //do
            //{
            //    Console.WriteLine($"{j}. Xin lỗi em lần sau anh không thế nữa.");
            //    j++;
            //} while (j >= 500);
            // Sẽ được ứng dụng trong menu khi đi thi (quan trọng)
            //string n;
            //do
            //{
            //    Console.WriteLine("---Menu---");
            //    Console.WriteLine("---1.Đẹp trai---");
            //    Console.WriteLine("---2.Có ny---");
            //    Console.WriteLine("---0.Thoát---");
            //    Console.WriteLine("Mời bạn chọn chức năng");
            //    n = Console.ReadLine();
            //} while (n != "0"); 
            // Mảng và list 
            // Trong C khai báo mảng int a[số lượng phần tử];
            //int[] arr = new int[2];
            //// Khai báo trong c# kiểu dữ liệu[] tên = new int[số lượng phần tử]
            //for (int i = 0; i < 2; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    // Nhập cho mảng
            //}
            ////foreach (kiểu dữ liệu của arr chính là những phần tử trong arr in arr)
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            // List ->
            //List<int> list = new List<int> { 1,2,3,4};
            //List<int> listNhapTuBanPhim = new List<int>();
            // Cú pháp khai báo list
            // Là mảng động sẽ tự động chỉnh kích thước nếu
            // thêm phần tử hoặc xóa.

            //for (int i = 0; i < 5; i++)
            //{
            //    int k = Convert.ToInt32(Console.ReadLine());
            //    // Muốn thêm vào list thì sẽ dùng phương thức Add()
            //    listNhapTuBanPhim.Add(k);
            //}
            //foreach (var item in listNhapTuBanPhim)
            //{
            //    Console.Write(" "+item);
            //}
            Child ducAnh = new Child(); // Dùng từ khóa new để khởi tạo
            Console.WriteLine("Mời bạn nhập tên");
            ducAnh.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tuổi");
            ducAnh.Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập cân nặng");
            ducAnh.CanNang = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập chiều cao");
            ducAnh.ChieuCao = Convert.ToSingle(Console.ReadLine());  
            Console.WriteLine("Mời bạn nhập giới tính");
            ducAnh.GioiTinh = Console.ReadLine(); 
            Console.WriteLine("Mời bạn nhập quê quán");
            ducAnh.QueQuan = Console.ReadLine();
            ducAnh.InThongTin();
            // constructor có tham số
            Console.ReadKey();
        }
    }
}
