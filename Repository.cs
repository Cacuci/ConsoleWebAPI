using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleWebAPI
{
    public class Repository
    {
        HttpClient client = new HttpClient();       

        public Repository()
        {
            client.BaseAddress = new Uri("http://localhost:5000");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Users>> GetUserAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/user");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Users>>(data);
            }

            return new List<Users>();
        }
    }
}