using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project.Models;
namespace Project.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        private Entities_new db = new Entities_new();

        public ActionResult Index()
        {
            //var netsalary = db.Stores.Where(x => x.product_id == data.ID && x.IsArchive == true).Select(x => x.NetSalary).LastOrDefault();

            //var last = db.Stores.OrderByDescending(p => p.product_id).LastOrDefault().product_id;

            /*var count = db.Stores.GroupBy(n => n.product_id)
                        .Select(g => new { Count = g.Count() }).ToList();*/


            /*var count = db.Stores.GroupBy(n => n.product_id)
                        .Select(g => new {Count = g.Count() }).ToList();*/

            /*List<Storecount> CountList = new List<Storecount>();

            for (int i = 0; i < count.ToList().Count; i++)
            {
                CountList.Add(new Storecount { Count = count[i].Count });
            }*/
            var data = db.Stores.Select(n => n.product_id).Count();
            ViewData["Message"] = data;

            return View();
        }
    }
}