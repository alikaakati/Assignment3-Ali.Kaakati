using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATM.ViewModel;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;

namespace ATM.Controllers
{
    public class CheckingAccountController : Controller
    {
        private ApplicationDbContext _context;
        public CheckingAccountController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: CheckingAccount
        [Route("CheckingAccount/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}