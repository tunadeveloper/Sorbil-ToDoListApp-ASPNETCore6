using Microsoft.AspNetCore.Mvc;
using YapilacaklarListesi.Models;

namespace YapilacaklarListesi.Controllers
{
    public class GorevController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var gorevler = context.YapilacakGorevs.OrderByDescending(x=>x.OlusturmaTarihi).ToList();
            return View(gorevler);
        }
         
        [HttpPost]
        public IActionResult Ekle(string baslik, string aciklama)
        {
            var gorev = new YapilacakGorev
            {
                Baslik = baslik,
                Aciklama = aciklama,
                OlusturmaTarihi = DateTime.Now
            };

            context.YapilacakGorevs.Add(gorev);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Tamamla(int id)
        {
            var gorev = context.YapilacakGorevs.Find(id);
            gorev.TamamlanmaTarihi = gorev.Tamamlandi ? DateTime.Now : null;
               gorev.Tamamlandi = !gorev.Tamamlandi;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult OnemliYap(int id)
        {
            var gorev = context.YapilacakGorevs.Find(id);
            gorev.Onemli = !gorev.Onemli;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            var gorev = context.YapilacakGorevs.Find(id);
            context.YapilacakGorevs.Remove(gorev);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
