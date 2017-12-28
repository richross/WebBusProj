using System.Threading;
using System.Threading.Tasks;
using WebBusProj.Models;

namespace WebBusProj.Utilities
{
    public interface IOrderQueueManager
    {
        Task ProcessMessagesAsync(CancellationToken cancellationToken);
        Task SendMessageAsync(Order order);
    }
}