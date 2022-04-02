using ResourceBox.Models;
using ResourceBox.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ResourceBox.Areas.FAQ.Controllers
{
    [RouteArea("FAQ")]
    public class FAQController : Controller
    {
        // GET: FAQ/FAQ
        public ActionResult FAQ()

        {
            SecurityDAO db = new SecurityDAO();
            ViewModel viewModel = new ViewModel();
            viewModel.Users = db.fetchUser();
            viewModel.UserChats = db.fetchMessages();
            viewModel.UserNotifications = db.fetchNotification(Convert.ToInt32(Session["userId"]));
            return View(viewModel);
        }
    }
}