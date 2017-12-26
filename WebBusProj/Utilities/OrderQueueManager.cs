using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBusProj.Utilities
{
    public class OrderQueueManager 
    {
        private CloudQueueClient cloudQueue;
        private IOrderTaskRepository repository;

        private static readonly string orderQueueName = "orderprocessing";

        public OrderQueueManager(IOrderTaskRepository _repo)
        {
            repository = _repo;
            CloudStorageAccount cloudStorageAccount = 
        }
    }
}
