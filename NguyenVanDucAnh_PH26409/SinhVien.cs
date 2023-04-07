using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanDucAnh_PH26409
{
    internal class SinhVien
    {
        //Tạo ra 1 class sinh viên
        // Mặc định các thuộc tính khi không có kiểu truy cập là private
        // Bôi đen các fields(các trường cần gen)
        // Chuột phải -> chọn Quick Actions and Refactorings
        // sau đó chọn Encapsulate fields 1 trong 2 trên dưới đều được

        // Gọi là các Fields
        string maSV;
        string hoTen;
        int namSinh;
        // Kết quả
        //Property
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        // Tạo nhanh Constructor không có tham số
        // ctor + tab
        public SinhVien()
        {

        }
        // Tạo nhanh Constructor có tham số
        // Bôi đen các Property-> Chuột phải -> chọn Quick Actions and Refactorings
        // Sau đó chọn Generate Constructor
        public SinhVien(string maSV, string hoTen, int namSinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NamSinh = namSinh;
        }
        public void inThongTin()
        {
            // Sẽ phải in ra hết các thông tin đề bài cho
            Console.WriteLine($"Mã sinh viên: {maSV}");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}");
        }
    }
}
