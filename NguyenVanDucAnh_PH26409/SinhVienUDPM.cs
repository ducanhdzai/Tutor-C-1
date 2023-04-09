using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class SinhVienUDPM : SinhVien // Chọn tên class bấm chuột phải -> chọn Quick Actions and Refactorings -> Chọn Generate constructor cái thứ 2 từ dưới lên
    {
        // Như là 1 lớp sinh viên bởi nó có thể sử dụng tất cả các thuộc tính và phương thức của thằng Sinh Viên
        // Và nó chỉ có thể kế thừa được 1 lớp khác 
        double diemCSharp;
        double diemJava;
     
        // Tạo constructor không có tham số
        // ctor + tab
        public SinhVienUDPM()
        {
            
        }

        public SinhVienUDPM(string maSV, string hoTen, int namSinh, double diemCSharp, double diemJava) : base(maSV, hoTen, namSinh)
        {
            DiemCSharp = diemCSharp; // Gắn giá trị được truyền vào cho property
            DiemJava = diemJava;
        }

        // Phải copy thêm các thuộc tính mới vào đây không cần phải copy vào base()

        // Tạo ra constructor có tham số

        // tạo property
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        // Bên thằng con phải có thủ tục pháp lý để nhận tài sản từ thằng cha
        // Chính là override
        public override void inThongTin()
        {

            base.inThongTin();//base.inThongTin() là dùng để lấy ra những gì thực hiện ở class cha
            Console.WriteLine($"Điểm C#: {diemCSharp}");
            Console.WriteLine($"Điểm Java: {diemJava}");
            // Hoàn thành kế thừa và in ra thêm thông tin mới
        }
    }
}
