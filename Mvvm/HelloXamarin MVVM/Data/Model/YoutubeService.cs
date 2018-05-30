using System.Net.Http;
using System.Threading.Tasks;

namespace Data.Model
{
    public class YoutubeService : IYoutubeService
    {
        public async Task<string> Refresh()
        {
            var client = new HttpClient();

            var html = await client.GetStringAsync("https://www.youtube.com/watch?v=_ntWKJoqsLQ");

            var div = "<div class=\"watch-view-count\">";

            var index = html.IndexOf(div) + div.Length;
            html = html.Substring(index);
            var index2 = html.IndexOf("<");
            html = html.Substring(0, index2);
            return html;
        }
    }
}
