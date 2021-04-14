using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyPackageNuget
{
    public class Class1
    {
        async Task DownloadAsync()
        {
            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync("");
        }
    }
}
