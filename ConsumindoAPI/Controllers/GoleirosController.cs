﻿using ConsumindoAPI.Mitagem;
using System.Web.Mvc;

namespace ConsumindoAPI.Controllers
{
    public class GoleirosController : Controller
    {
        private MitagemEstatistica _mitagemGoleiro;

        public GoleirosController()
        {
            _mitagemGoleiro = new MitagemEstatistica();
        }
        
        // GET: Goleiros
        public ActionResult Index()
        {
            //1-Goleiro
            return View(_mitagemGoleiro.Mitos(1));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
