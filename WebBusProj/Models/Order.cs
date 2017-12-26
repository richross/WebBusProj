using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBusProj.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string OrderTitle { get; set; }
        public string OrderPayment { get; set; }
        public DateTime OrderDateTime { get; set; }

    }
}
