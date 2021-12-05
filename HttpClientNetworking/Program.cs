// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

namespace HttpClientNetworking
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task task = Downloader.DownloadWebPage();
            task.GetAwaiter().GetResult();
        }
    }
}


