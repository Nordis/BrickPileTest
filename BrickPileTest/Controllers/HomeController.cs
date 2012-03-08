using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrickPile.Domain.Models;
using BrickPileTest.Models;
using Raven.Client;

namespace BrickPileTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly Home _model;
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(_model);
        }

        public HomeController(IPageModel model, IDocumentSession session)
        {
            _model = model as Home;
        }

    }
}
