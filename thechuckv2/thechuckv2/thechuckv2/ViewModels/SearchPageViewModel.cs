using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using thechuckv2.Dto;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace thechuckv2.ViewModels
{
    class SearchPageViewModel : BaseViewModel
    {
        public ObservableCollection<JokeDto> Jokes { get; } = new ObservableCollection<JokeDto>();
        //public ICommand UserSearchCommand;
        public SearchPageViewModel()
        {
            Title = "Search Facts";

            //UserSearchCommand = new Command(
            //    async () => await Search(_query),
            //    () => !IsBusy);

            //UserSearchCommand = new Command(
            //    async () => await OnSearchClicked(_query),
            //    () => !IsBusy);

            //UserSearchCommand = new Command(OnSearchClicked(_query));   
        }

        string _query = string.Empty;

        public string Query
        {
            get { return _query; }
            set { 
                    _query = value;
                    OnPropertyChanged(nameof(Query));
                }
        }

        //private async Task OnSearchClicked(string query)
        //{
        //    IsBusy = true;

        //    var jokes = await _apiService.GetSearchResult(query);

        //    Jokes.Clear();

        //    if (jokes != null)
        //    {
        //        foreach (var joke in jokes.result)
        //        {
        //            Jokes.Add(joke);
        //        }
        //    }

        //    IsBusy = false;
        //}

        public async Task Search(string query)
        {
            IsBusy = true;

            var jokes = await _apiService.GetSearchResult(query);

            Jokes.Clear();

            if (jokes != null)
            {
                foreach (var joke in jokes.result)
                {
                    Jokes.Add(joke);
                }
            }

            IsBusy = false;
        }

    }
}
