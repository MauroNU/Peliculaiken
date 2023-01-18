using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Peliculaiken.Data;
using Peliculas.Models;

namespace Peliculaiken.Controllers
{
    public class PeliculasController : Controller
    {
        private ApplicationDBContext _context;

        public PeliculasController(ApplicationDBContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var peliculas = _context.Peliculas.ToList();

            return View(peliculas);
        }
        public ActionResult BuscarPelicula(string nombre)
        {
            var pelicula = _context.Peliculas;
            return View(pelicula);
        }
        public ActionResult Detalles(string nombre)
        {
            var pelicula = _context.Peliculas.SingleOrDefault(p => p.Nombre == nombre);

            if (pelicula == null)
                return NotFound();

            return View(pelicula);
        }

        [HttpGet]
        public ActionResult AñadirPelicula()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AñadirPelicula(Pelicula pelicula)
        {
            if (pelicula == null)
                return NotFound();
            _context.Peliculas.Add(pelicula);
            _context.SaveChanges();
            return RedirectToAction("Index","Peliculas");
        }
    }
}
