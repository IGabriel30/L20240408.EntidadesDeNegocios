using L20240408.EntidadesDeNegocios;
using L20240408.LogicaDeNegocios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L20240408.UI.AppWebMVC.Controllers
{
    public class PersonaLController : Controller
    {
        readonly PersonaLBL _personaLBL;
        public PersonaLController(PersonaLBL personaLBL)
        {
            _personaLBL = personaLBL;
        }
        // GET: PersonaController
        public async Task<ActionResult> Index(PersonaL personaL)
        {
            var persona = await _personaLBL.Buscar(personaL);
            return View(persona);
        }

        // GET: PersonaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var persona = await _personaLBL.ObtenerPoId(new PersonaL { Id = id });
            return View(persona);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaL personaL)
        {
            try
            {
                await _personaLBL.Crear(personaL);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var persona = await _personaLBL.ObtenerPoId(new PersonaL { Id = id });
            return View(persona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaL personaL)
        {
            try
            {
                await _personaLBL.Modificar(personaL);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var persona = await _personaLBL.ObtenerPoId(new PersonaL { Id = id });
            return View(persona);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaL personaL)
        {
            try
            {
                await _personaLBL.Eliminar(personaL);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
