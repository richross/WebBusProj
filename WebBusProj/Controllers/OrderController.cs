using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebBusProj.Models;
using WebBusProj.Utilities;

namespace WebBusProj.Controllers
{
    public class OrderController : Controller
    {
        private ServiceBusSettings settings { get; set; }
        public OrderController(IOptions<ServiceBusSettings> _settings)
        {
            settings = _settings.Value;
        }
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
            OrderQueueManager manager = new OrderQueueManager(settings);
            Order thisOrder = new Order()
            {
                OrderId = formCollection["OrderId"],
                OrderTitle = formCollection["OrderTitle"],
                OrderPayment = formCollection["OrderPayment"],
                OrderDateTime = Convert.ToDateTime(formCollection["OrderDateTime"])
            };
            manager.SendMessageAsync(thisOrder);

            return View();
        }
    }
}