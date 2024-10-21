using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuoiHai_Limupa.Models;

namespace MuoiHai_Limupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeAPIController : ControllerBase
    {
        public QlthuVienContext db =new QlthuVienContext();

        [HttpGet("{maNXB}")]
        public IEnumerable<TSach> LaySachTheoMa(string maNXB)
        {
            var list_sach = db.TSaches.Where(x => x.MaNxb ==maNXB).ToList();
            return list_sach;
        }
    }
}
