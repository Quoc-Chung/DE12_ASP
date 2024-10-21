using Microsoft.AspNetCore.Mvc;
using MuoiHai_Limupa.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MuoiHai_Limupa.Controllers
{
    public class HomeController : Controller
    {
        public QlthuVienContext db = new QlthuVienContext();

        public IActionResult Index()
        {
            ViewBag.TenNhaXuatBan = db.TNhaXbs.ToList();
            var list_docGia = db.TDocGia.ToList();
            return View(list_docGia);
        }

        [Route("ThemSachMoi")]
        [HttpGet]

        public IActionResult ThemSachMoi()
        {
            ViewBag.MaLoai = new SelectList(db.TLoaiSaches.ToList(), "MaLoai", "TenLoai");
            ViewBag.MaNgonNgu = new SelectList(db.TNgonNgus.ToList(), "MaNgonNgu", "TenNgonNgu");
            ViewBag.MaNxb = new SelectList(db.TNhaXbs.ToList(), "MaNxb", "TenNxb");
            ViewBag.TenNhaXuatBan = db.TNhaXbs.ToList();
            return View();
        }

        [Route("ThemSachMoi")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSachMoi(TSach Sach)
        {
            /*- == true thì chứng tỏ dứ liệu truyền từ form vào hợp lệ -*/
            if (ModelState.IsValid)
            {
                db.Add(Sach);
                db.SaveChanges();
                return RedirectToAction("Index"); // Chuyển hướng về trang danh sách
            }
            ViewBag.TenNhaXuatBan = db.TNhaXbs.ToList();
            return View();
        }


    }
}


