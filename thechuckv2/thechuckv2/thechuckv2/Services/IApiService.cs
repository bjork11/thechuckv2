using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using thechuckv2.Dto;

namespace thechuckv2.Services
{
    public interface IApiService
    {
        Task GetAllCategoriesAsync();
        Task<JokeDto> GetRandomJoke();
        Task GetSearchResultAsync();
    }
}
