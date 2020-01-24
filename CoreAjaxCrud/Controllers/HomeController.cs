using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreAjaxCrud.Models;

namespace CoreAjaxCrud.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public ActionResult getUser()
        {
            //DatabaseEntities db = new DatabaseEntities();
            return Json(_context.User.Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            }).ToList());
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(_context.User.ToList());
        }
        public JsonResult Add([FromBody]Users user)
        {
           
            _context.User.Add(user);
            _context.SaveChanges();
            return Json(user);
        }
        public JsonResult GetbyID(int ID)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == ID);

            return Json(user);
        }
        public JsonResult Update([FromBody]Users user)
        {
            var data = _context.User.FirstOrDefault(x => x.Id == user.Id);
            if (data != null)
            {
                data.Name = user.Name;
                data.State = user.State;
                data.Country = user.Country;
                data.Age = user.Age;
                _context.SaveChanges();
            }
            return Json(user);
        }
        public JsonResult Delete(int ID)
        {
            var data = _context.User.FirstOrDefault(x => x.Id == ID);
            _context.User.Remove(data);
            _context.SaveChanges();
            return Json(data);
        }

    }
}

