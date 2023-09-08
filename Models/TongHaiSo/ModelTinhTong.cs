
namespace DemoWebMvc.Models.TongHaiSo
{
    public class ModelTinhTong
    {
        public int SoNguyen1 { get; set; }
        public int SoNguyen2 { get; set; }
        public int Total { get; set; }

        //hàm khởi tạo mặc định
        public ModelTinhTong() { }

        //ham khởi tạo có tham số
        public ModelTinhTong(int SoNguyen1, int SoNguyen2) 
        {
            this.SoNguyen1 = SoNguyen1;
            this.SoNguyen2 = SoNguyen2;
            this.Total = SoNguyen1 + SoNguyen2;
        }
    }
}
