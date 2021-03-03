using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tiket_reservation.Helper;
using tiket_reservation.Models;
using tiket_reservation.Security;

namespace tiket_reservation.Controllers
{
    [AuthorizationFilterUser]
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult dashboard()
        {
            return View();
        }

        public ActionResult log_out()
        {
            Session.Remove("user");
            Session.Remove("email");
            Session.Remove("id");
            return RedirectToAction("index", "Home");
        }

    }
}
