using MLBTeamsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MLBPlayersApp.Services
{
    public class ApiService : IApiService
    {
        public async Task<IList<Team>> GetTeamsList(string SeassonType, string Seasson)
        {
            HttpClient httpClient = new HttpClient();
            const string url = "https://lookup-service-prod.mlb.com/json/named.team_all_season.bam?sport_code='mlb'&";
            var result = await httpClient.GetStringAsync($"{url}all_star_sw='{SeassonType}'&sort_order='name_asc'&season={Seasson}");
            var data = JsonConvert.DeserializeObject<TeamQuery>(result);
            return data.TeamAllSeason.QueryResults.Teams;

        }
    }
}
