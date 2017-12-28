using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBusProj.Models
{
    public class ServiceBusSettings
    {
        /// <summary>
        /// Class for collecting and using the app settings related to communicating with the
        /// Service Bus.  For .net Configuration to work this needs to be an empty constructor.
        /// The properties also need to match the name of the key in the settings file.
        /// </summary>
        public ServiceBusSettings()
        {

        }

        public string ConnectionString { get; set; }
        public string SASReadKey { get; set; }
        public string TopicName { get; set; }
        public string SubscriptionName { get; set; }
    }
}
