using Flurl;
using Flurl.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _96h.Tools
{
    public class RequestFlurl : IRequestFlurl
    {
        private string baseUrl = @"http://62.80.185.165:3636/api/";

        public async Task<T> GetRequestAsync<T>(string segment, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await baseUrl.AppendPathSegment(segment: segment).GetJsonAsync<T>();

            return response;
        }
    }

    public interface IRequestFlurl
    {
        Task<T> GetRequestAsync<T>(string method, CancellationToken cancellationToken = default);
    }
}
