using JkSolucoes.Consultoria.Data;
using JkSolucoes.Consultoria.Models;
using JkSolucoes.Consultoria.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JkSolucoes.Consultoria.Controllers
{
    public class ImagesController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromServices] ApplicationContext db)
        {
            return View(db.Imagem.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Imagem Image, [FromServices] ApplicationContext db)
        {

            Image.Picture = Image.Img.ToByteArray();
            Image.Length = (int)Image.Img.Length;
            Image.Extension = Image.Img.GetExtension();
            Image.ContentType = Image.Img.ContentType;
            db.Imagem.Add(Image);
            db.SaveChanges();

            

          //  var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\File", Img.FileName);
           // var stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            //Img.CopyToAsync(stream);
            
                

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ResponseCache(Duration = 3600)]
        public FileResult Render(string id, [FromServices] ApplicationContext db)
        {
            Guid _id = Guid.Parse(id);

            var item = db.Imagem
                .Where(x => x.Id == _id)
                .Select(s => new { s.Picture, s.ContentType })
                .FirstOrDefault();

            if (item != null)
            {
                return File(item.Picture, item.ContentType);
            }

            return null;
        }


    }
}
