using System.Threading;
using System.Threading.Tasks;
using WebBusProj.Models;

namespace WebBusProj.Utilities
{
    public interface IOrderQueueManager
    {
        /// <summary>
        /// Method for sending messages to the Service Bus
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        Task SendMessageAsync(Order order);

        /// <summary>
        /// Method for processing messages placed on the Service Bus
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ProcessMessagesAsync(CancellationToken cancellationToken);
    }
}