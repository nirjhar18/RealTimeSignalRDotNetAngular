using System.Threading.Tasks;

namespace DotNETCoreAPI.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }

}
