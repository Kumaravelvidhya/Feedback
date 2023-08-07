using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedbacks.Business;
using Feedback.Models;

namespace FeedbackMVC.Controllers
{
    public class FeedbackController : Controller
    {
        FeedbackRepository objfeed;
        public FeedbackController()
        {
             objfeed = new FeedbackRepository();
        }
        // GET: FeedbackController1
        public ActionResult List()
        {
            return View("Select", new List<FeedbackModel>(objfeed.Select()));
        }

        // GET: FeedbackController1/Details/5
        public ActionResult Details(int Customerid)
        {
            var result = objfeed.Selectwithid(Customerid);
            return View("Details", result);
        }

        // GET: FeedbackController1/Create
        public ActionResult Create()
        {
            return View("Create", new FeedbackModel());
        }

        // POST: FeedbackController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FeedbackModel fee)
        {
            try
            {

                objfeed.insert(fee);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackController1/Edit/5
        public ActionResult Edit(int CustomerId)
        {
            var result = objfeed.Selectwithid(CustomerId);
            return View("Update", result);
        }

        // POST: FeedbackController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string Customername, FeedbackModel feed)
        {
            try
            {
                objfeed.updatesp(feed);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedbackController1/Delete/5
        public ActionResult Delete(int CustomerId)
        {
            var result = objfeed.Selectwithid(CustomerId);

            return View("Delete",result);
        }

        // POST: FeedbackController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int CustomerId)
        {
            try
            {
                objfeed.deletesp(CustomerId);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
