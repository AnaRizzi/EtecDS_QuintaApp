using QuintaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuintaApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            // validação de um único item:
            //if (string.IsNullOrEmpty(usuario.UsuNome))
            //{
            //    ModelState.AddModelError("UsuNome", "O campo nome é obrigatório");
            //}
            //if (usuario.UsuSenha != usuario.UsuConfirmaSenha)
            //{
            //    ModelState.AddModelError("", "As senhas são diferentes");
            //}

            if (ModelState.IsValid)
            {            
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult ValidaLogin(string UsuLogin)
        {
            var dbExemplo = new Collection<string>
            {
                "Adriana",
                "Amanda",
                "Alberto"
            };
            return Json(dbExemplo.All(a => a.ToLower() != UsuLogin.ToLower()),JsonRequestBehavior.AllowGet);
        }
    }
}