using DemoWebMvc.Models.Entity;
using DemoWebMvc.Models.TongHaiSo;

namespace DemoWebMvc.Models.View
{
    public class ViewModelTinhTong
    {
        public ModelTinhTong MDTinhTong { get; set; }
        public ModelTinhHieu MDTinhHieu { get; set; }

        public ViewModelTinhTong()
        {
            MDTinhTong = new ModelTinhTong();
            MDTinhHieu = new ModelTinhHieu();
        }
    }
}
