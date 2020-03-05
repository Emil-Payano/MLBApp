using MLBPlayersApp.Services;
using MLBTeamsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MLBTeamsApp.ViewModels
{
   public class TeamsPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Team> teams { get; set; }
      
        public IApiService _apiService = new ApiService();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Entry { get; set; }

        public string SecondEntry { get; set; }
        public bool IsActiveCheckBox { get; set; } = true;
        public string SearchEntry { get; set; }
        public ICommand GetTeamInformationCommand { get; set; }

        public TeamsPageViewModel()
        {
            GetTeamInformationCommand = new Command(async() =>
            {
              await GetPlayerData();
            });
        }

        async Task GetPlayerData()
        {
        
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    try
                    {
                        if (IsActiveCheckBox == true)
                        {
                            Entry = "N";

                            teams = new ObservableCollection<Team>(await _apiService.GetTeamsList(Entry, SecondEntry));
                        }
                        else
                        {
                            Entry = "Y";

                            teams = new ObservableCollection<Team>(await _apiService.GetTeamsList(Entry, SecondEntry));
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"API EXCEPTION {ex}");
                    }

                }
                else
                {
                    //Show internet connection error message HERE
                }
        }
                             
   }
}

