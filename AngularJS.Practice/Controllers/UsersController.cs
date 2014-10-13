using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS.Practice.Helper;
using AngularJS.Practice.Models;

namespace AngularJS.Practice.Controllers
{
    public class UsersController : JsonController
    {
        //
        // GET: /Users/
        private  readonly  Mockdb _db = new Mockdb();
        public ActionResult Index()
        {
            return Json(_db.Creatuserdb(),JsonRequestBehavior.AllowGet);
        }

    }
}
