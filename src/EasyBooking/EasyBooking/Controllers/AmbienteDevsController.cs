using EasyBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBooking.Controllers
{
    public class AmbienteDevsController : Controller
    {
        private readonly AppDbContext _context;
        public AmbienteDevsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.AmbienteDevs.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AmbienteDev ambienteDev)
        {
            if (ModelState.IsValid)
            {
                _context.AmbienteDevs.Add(ambienteDev);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ambienteDev);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.AmbienteDevs.FindAsync(id);

            if (dados == null)

                return NotFound();

            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AmbienteDev ambienteDev)
        {
            if (id != ambienteDev.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.AmbienteDevs.Update(ambienteDev);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.AmbienteDevs.FindAsync(id);

            if (dados == null)

                return NotFound();

            return View(dados);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.AmbienteDevs.FindAsync(id);

            if (dados == null)

                return NotFound();

            return View(dados);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.AmbienteDevs.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.AmbienteDevs.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Relatorio(int id)
        {
            if (id == null)
                return NotFound();

           var ambientedev = await _context.AmbienteDevs.FindAsync(id);
            if (ambientedev == null)
                return NotFound();

            var reservas = await _context.Reservas
                .Where(c => c.AmbienteId == id)
                .OrderByDescending(c => c.UserId)
                .ToListAsync();

            int totalReservas = reservas.Sum(c => c.AmbienteId);

            ViewBag.Ambiente = ambientedev.NomeAmbiente;
            ViewBag.TotalReservas = totalReservas;

            return View(reservas);

        }
    }
}
