using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Lab3.Models;

namespace ASP_Lab3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ListModel list = new ListModel();
            list.List = repos.GetList();
            list.Values = new string[] { };// { "1" };
            return View(list);
        }

        IRepository<SelectListItem> repos;

        public HomeController(IRepository<SelectListItem> repository)
        {
            repos = repository;
        }
        //[ActionName("Add")]
        public ActionResult Add(string addvalue)
        {
            repos.Add(new SelectListItem() { Text = addvalue });
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Index(ListModel model, string action)
        {
            if (model != null)
            {
                if (action == "Удалить")
                {
                    repos.List = repos.List.Where(t => !model.Values.Contains(t.Value)).ToList();
                }
                else
                    if (action == "Добавить")
                {
                    int max = repos.List.Select(t => int.Parse(t.Value)).Max();
                    repos.Add(new SelectListItem { Text = model.AddedValue, Value = (max+1).ToString() });
                }
            }
            return RedirectToAction("Index");
        }
    }
}