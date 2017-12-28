using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebBusProj.Models;

namespace WebBusProj.Utilities
{
    public class OrderQueueManager : IOrderQueueManager
    {
        private CloudQueueClient cloudQueue;
        private IOrderTaskRepository repository;

        private static readonly string orderQueueName = "orderprocessing";

        public OrderQueueManager(IOrderTaskRepository _repo, ServiceBusSettings optionsAccessor)
        {
            //optionsAccessor;
            repository = _repo;
        }

        public Task ProcessMessagesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SendMessageAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
