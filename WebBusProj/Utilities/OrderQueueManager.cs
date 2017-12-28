using Microsoft.Extensions.Options;
using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebBusProj.Models;
using Newtonsoft.Json;
using System.Text;

namespace WebBusProj.Utilities
{
    public class OrderQueueManager : IOrderQueueManager
    {
        private ITopicClient topicClient;
        private IOrderTaskRepository repository;
        private ServiceBusSettings settings;

        private static readonly string orderQueueName = "orderprocessing";

        public OrderQueueManager(ServiceBusSettings optionsSettings)
        {
            settings = optionsSettings;
            topicClient = new TopicClient(settings.ConnectionString, settings.TopicName);
        }

        public Task ProcessMessagesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task SendMessageAsync(Order order)
        {
            try
            {
                string orderJson = JsonConvert.SerializeObject(order);
                Message orderMessage = new Message(Encoding.UTF8.GetBytes(orderJson));
                orderMessage.MessageId = order.OrderId;
                await topicClient.SendAsync(orderMessage);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
