using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Central_Dispatch_Prototype.Models;

namespace Central_Dispatch_Prototype.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Options()
        {
            var model = new Preferences { Payout = Payment.opt1, Rating = Rating.opt5 };
            return View(model);
        }

        [HttpPost]
        public ActionResult Options(Preferences model)
        {
            return RedirectToAction("Ranking", model);
        }

        [HttpGet]
        public ActionResult Results(Preferences model)
        {
            Preferences updatedModel = model;
            updatedModel.Rating = model.Rating;
            updatedModel.Endpoint = model.Endpoint;
            updatedModel.Starting = model.Starting;
            updatedModel.Payout = model.Payout;

            updatedModel.top = model.top;
            updatedModel.second = model.second;
            updatedModel.third = model.third;
            updatedModel.last = model.last;

            updatedModel.populateResults(updatedModel);
            return View(updatedModel);
        }

        [HttpGet]
        public ActionResult Ranking(Preferences model)
        {
            Preferences updatedModel = model;
            updatedModel.Rating = model.Rating;
            updatedModel.Endpoint = model.Endpoint;
            updatedModel.Starting = model.Starting;
            updatedModel.Payout = model.Payout;
            return View(updatedModel);
        }

        //how to get this to stop yelling at me?
        [HttpPost, ActionName("Ranking")]
        public ActionResult RankingPost(Preferences model)
        {
            return RedirectToAction("Results", model);
        }
    }
}