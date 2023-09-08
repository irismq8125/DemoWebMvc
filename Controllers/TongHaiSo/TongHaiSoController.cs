using DemoWebMvc.Models.TongHaiSo;
using DemoWebMvc.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebMvc.Controllers.TongHaiSo
{
    public class TongHaiSoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ViewModelTinhTong();
            ViewData["Message"] = "";
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ModelTinhTong input)
        {
            var model = new ViewModelTinhTong();
            var result = new ModelTinhTong(input.SoNguyen1, input.SoNguyen2);
            model.MDTinhTong = result;
            ViewData["Message"] = "";
            return View(model);
        }


        //[HttpPost]
        //public IActionResult Index(int soNguyen1, int soNguyen2)
        //{
        //    ViewData["SoNguyen1"] = soNguyen1;
        //    ViewData["SoNguyen2"] = soNguyen2;
        //    ViewData["KetQua"] = soNguyen1 + soNguyen2;
        //    ViewData["Message"] = "";
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult Index(int soNguyen1, int soNguyen2)
        //{
        //    try
        //    {
        //        ViewData["SoNguyen1"] = soNguyen1;
        //        ViewData["SoNguyen2"] = soNguyen2;
        //        ViewData["KetQua"] = soNguyen1 / soNguyen2;
        //        ViewData["Message"] = "";
        //    }
        //    catch (DivideByZeroException dex)
        //    {
        //        ViewData["Message"] = "Khong dc phep chia cho 0";
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["Message"] = ex.Message;
        //    }
        //    return View();
        //}
    }
}
