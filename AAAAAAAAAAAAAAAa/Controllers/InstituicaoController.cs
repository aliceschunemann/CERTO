using AAAAAAAAAAAAAAAa.Models;
using AAAAAAAAAAAAAAAa.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AAAAAAAAAAAAAAAa.Controllers
{
    public class InstituicaoController : Controller
    {
        private readonly IESContext _context;

        private static IList<Instituicao> instituicoes =
            new List<Instituicao>()
            {
                new Instituicao() {
                    InstituicaoID = 1,
                    Nome = "UniParaná",
                    Endereco = "Paraná"
                },
                new Instituicao() {
                    InstituicaoID = 2,
                    Nome = "UniSanta",
                    Endereco = "Santa Catarina"
                },
                new Instituicao() {
                    InstituicaoID = 3,
                    Nome = "UniSãoPaulo",
                    Endereco = "São Paulo"
                },
                new Instituicao() {
                    InstituicaoID = 4,
                    Nome = "UniSulgrandense",
                    Endereco = "Rio Grande do Sul"
                },
                new Instituicao() {
                    InstituicaoID = 5,
                    Nome = "UniCarioca",
                    Endereco = "Rio de Janeiro"
                }
            };
        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.Nome));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        // POST: Instituicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var instituicao = await _context.Instituicoes.SingleOrDefaultAsync(m => m.InstituicaoID == id);
            _context.Instituicoes.Remove(instituicao);
            await _context.SaveChangesAsync();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            return RedirectToAction("Index");
        }
    }
}
