using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using thechuckv2.Dto;
using Newtonsoft.Json;
using thechuckv2.Pages;

namespace thechuckv2.Services
{
    public class ApiService : IApiService
    {
        public Task GetAllCategoriesAsync()
        {
            throw new NotImplementedException();  
        }

        public async Task<JokeDto> GetRandomJoke()
        {
            var data = await GetData("https://api.chucknorris.io/jokes/random");

            return JsonConvert.DeserializeObject<JokeDto>(data);
        }

        public Task GetSearchResultAsync()
        {
            throw new NotImplementedException();
        }

        private async Task<string> GetData(string url)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }
    }
}
