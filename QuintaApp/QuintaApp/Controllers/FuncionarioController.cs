using QuintaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuintaApp.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario()
            {
                FuncId = 1,
                FuncNome = "Bronquinho",
                FuncFuncao = "Folião"
            };
            return View(func);
        }

        //[HttpPost]
        //public ActionResult Listar(ushort FuncId, string FuncNome, string FuncFuncao) - os parâmetros têm o mesmo nome dado aos campos no form
        //{
        //    ViewData["FuncId"] = FuncId;
        //    ViewData["FuncNome"] = FuncNome;
        //    ViewData["FuncFuncao"] =FuncFuncao;
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Listar(FormCollection form)
        //{
        //    ViewData["FuncId"] = form["FuncId"];
        //    ViewData["FuncNome"] = form["FuncNome"];
        //    ViewData["FuncFuncao"] = form["FuncFuncao"];
        //    return View();
        //}

        [HttpPost]
        public ActionResult Listar(Funcionario func)
        {
            //ViewData["FuncId"] = func.FuncId;
            //ViewData["FuncNome"] = func.FuncNome;
            //ViewData["FuncFuncao"] = func.FuncFuncao;
            return View(func);
        }
    }
}