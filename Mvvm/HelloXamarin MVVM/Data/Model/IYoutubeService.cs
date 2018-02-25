using System.Threading.Tasks;

namespace Data
{
    public interface IYoutubeService
    {
        Task<string> Refresh();
    }
}