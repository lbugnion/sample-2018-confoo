using System.Threading.Tasks;

namespace Data.Model
{
    public interface IYoutubeService
    {
        Task<string> Refresh();
    }
}
