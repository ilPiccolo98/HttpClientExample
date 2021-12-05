using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HttpClientNetworking
{
    internal class Downloader
    {
        public static async Task DownloadWebPage()
        {
            using HttpClient httpClient = new();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
            if(responseMessage.IsSuccessStatusCode)
            {
                byte[] data = await responseMessage.Content.ReadAsByteArrayAsync();
                using FileStream fileStream = File.Create(fileName);
                await fileStream.WriteAsync(data);
            }
        }

        private const string url = "https://16bpp.net/";
        private const string fileName = "index.html";
    }
}
