using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CRUD_MVC.Context;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AppDbContext _context;

        public ContatoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listaContatos = _context.Contatos.ToList();
            return View(listaContatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato novoContato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(novoContato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(novoContato);
            }
        }

        public IActionResult Detalhar(int id)
        {
            var contatoSelecionado = _context.Contatos.Find(id);

            if (contatoSelecionado == null)
                return RedirectToAction(nameof(Index));

            return View(contatoSelecionado);
        }

        public IActionResult Editar(int id)
        {
            var contatoSelecionado = _context.Contatos.Find(id);
            if (contatoSelecionado == null)
                return RedirectToAction(nameof(Index));
            return View(contatoSelecionado);
        }

        [HttpPost]
        public IActionResult Editar(Contato contatoAlterado)
        {
            var contatoDb = _context.Contatos.Find(contatoAlterado.ContatoId);

            contatoDb.Nome = contatoAlterado.Nome;
            contatoDb.Telefone = contatoAlterado.Telefone;
            contatoDb.Email = contatoAlterado.Email;
            contatoDb.Ativo = contatoAlterado.Ativo;

            _context.Contatos.Update(contatoDb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var contatoSelecionado = _context.Contatos.Find(id);

            if (contatoSelecionado == null)
                return RedirectToAction(nameof(Index));

            return View(contatoSelecionado);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contatoExcluir)
        {
            var contatoDb = _context.Contatos.Find(contatoExcluir.ContatoId);

            _context.Contatos.Remove(contatoDb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



    }
}