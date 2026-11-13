using ClienteWEB.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteWEB.Controllers
{
    public class CursosController : Controller
    {
        private readonly CursoServicio _cursoServicio;

        public CursosController(CursoServicio cursoServicio)
        {
            this._cursoServicio = cursoServicio;
        }

        // GET: CursosController1
        public async Task<ActionResult> Index()
        {
            var cursos = await _cursoServicio.ObtenerCursos();
            return View(cursos);
        }

        // GET: CursosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
