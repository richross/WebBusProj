using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebBusProj.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Create or Edit Order
        /// </summary>
        /// <returns>IActionResult - The view for this action.</returns>
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(IFormCollection formCollection)
        {
            //write the record out to the service bus topic queue.


            return View();
        }
    }
}