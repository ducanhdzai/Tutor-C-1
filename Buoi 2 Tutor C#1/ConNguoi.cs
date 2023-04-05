using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Tutor_C_1
{
    internal class ConNguoi
    {
        // Tên, tuổi, giới tính, màu da, cân nặng, chiều cao,...
        //
        string ten;
        int tuoi;
        float canNang;
        float chieuCao;
        string gioiTinh;

        // Constructor - để tạo ra các thuộc tính của đối tượng
        // cách viết nhanh ctor + tab
        public ConNguoi() // Constructor không có tham số
        {
            
        }

        public ConNguoi(string ten, int tuoi, float canNang, float chieuCao, string gioiTinh)
        {
            Ten = ten;
            Tuoi = tuoi;
            CanNang = canNang;
            ChieuCao = chieuCao;
            GioiTinh = gioiTinh;
        }

        // Constructor có tham số

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public float ChieuCao { get => chieuCao; set => chieuCao = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        // Phải có property thì mới dùng được các thuộc tính
        // Thằng này là thằng trung gian
        // Tính chất đầu tiên của oop tính bao đóng
        // Phục vụ cho việc giới hạn truy cập dữ liệu
        // Tăng tính bảo mật
        // Sẽ có các loại truy cập như sau
        // 1.Public: có thể dùng ở mọi nơi
        // 2. Private: Sẽ chỉ được dùng ở class đó.
        // Nếu không khai báo kiểu truy cập mặc định là private
        // internal: là chỉ được dùng trong assembly
        // protected: truy cập trong class cha và con 
        // protected internal: internal + protectd

        //Làm sao để kế thừa lại thằng InThongTin
        public virtual void InThongTin()
        {
            Console.WriteLine($"Tên {ten}");
            Console.WriteLine($"Tuổi {tuoi}");
            Console.WriteLine($"Cân nặng {canNang}");
            Console.WriteLine($"Chiều cao {chieuCao}");
            Console.WriteLine($"Giới tính {gioiTinh}");
        }
    }
}
