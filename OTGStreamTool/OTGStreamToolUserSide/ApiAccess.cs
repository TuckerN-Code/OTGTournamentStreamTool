using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text;
using OTGStreamToolBackEnd;

namespace OTGStreamToolUserSide
{
    public class ApiAccess
    {
        private UpdatePackage updatePackage = new UpdatePackage();
        private static HttpClient client = new HttpClient();
        public ApiAccess(UpdatePackage inPack)
        {
            updatePackage = inPack;
            //Task.Run(() => GetTaskAsync("https://localhost:5001/api/player")).Wait();
            Task.Run(() => UpdateInfoAsync()).Wait();
        }

        private async Task UpdateInfoAsync()
        {
            
            HttpResponseMessage responce = await client.PutAsJsonAsync("https://localhost:5001/api/player", updatePackage);

            responce.EnsureSuccessStatusCode();
        }

        private async Task GetTaskAsync(string path)
        {
            object update;
            HttpResponseMessage respone = await client.GetAsync(path);
            if (respone.IsSuccessStatusCode)
            {
                update = await respone.Content.ReadAsStreamAsync();
            }
        }

    }
}
