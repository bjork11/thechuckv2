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
        public async Task<string[]> GetAllCategories()
        {
            var data = await GetData("https://api.chucknorris.io/jokes/categories");
            return JsonConvert.DeserializeObject<string[]>(data);
        }

        public async Task<JokeDto> GetRandomJoke()
        {
            var data = await GetData("https://api.chucknorris.io/jokes/random");
            return JsonConvert.DeserializeObject<JokeDto>(data);
        }

        public async Task<JokeDto> GetJokeByCategory(string category)
        {
            var data = await GetData($"https://api.chucknorris.io/jokes/random?category={category}");
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
