using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using thechuckv2.Dto;

namespace thechuckv2.Services
{
    public interface IApiService
    {
        Task<string[]> GetAllCategories();
        Task<JokeDto> GetRandomJoke();
        Task<JokeDto> GetJokeByCategory(string category);
        Task GetSearchResultAsync();
    }
}
