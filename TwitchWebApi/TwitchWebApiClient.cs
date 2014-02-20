using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;


namespace TwitchWebApi
{
    public interface ITwitchWebApiClient
    {
        GamesTopResponse GamesTop(int limit = 25, int offset = 0, bool hls = false);
        SearchGamesResponse SearchGames(string query, bool live, string type = "suggest");
        IngestsResponse Ingests();
        TeamResponse Team(string team);
        TeamsResponse Teams(int limit = 25, int offset = 0);
        UserResponse User(string name);
        VideoResponse Video(string id);
        VideosTopResponse VideosTop(string game = "", Period type = Period.Week, int limit = 10, int offset = 0);


        
    }
    public class TwitchWebApiClient : ITwitchWebApiClient
    {
        const string BaseUrl = "https://api.twitch.tv/kraken";
        
        readonly string _clientId;

        public TwitchWebApiClient(string clientId) 
        {
            _clientId = clientId;      
        }

        public GamesTopResponse GamesTop(int limit = 25, int offset = 0, bool hls = false)
        {
            var request = new RestRequest();
            request.Resource = "/games/top";
            request.AddParameter("limit", limit, ParameterType.QueryString);
            request.AddParameter("offset", offset, ParameterType.QueryString);
            request.AddParameter("hls", hls, ParameterType.QueryString);
            return Execute<GamesTopResponse>(request);
        }

        public SearchGamesResponse SearchGames(string query, bool live, string type = "suggest")
        {
            var request = new RestRequest();
            request.Resource = "/search/games";
            request.AddParameter("query", query);
            request.AddParameter("type", type);
            request.AddParameter("live", live);
            return Execute<SearchGamesResponse>(request);
        }

        public IngestsResponse Ingests()
        {
            var request = new RestRequest();
            request.Resource = "/ingests";
            return Execute<IngestsResponse>(request);
        }

        public TeamResponse Team(string team)
        {
            var request = new RestRequest();
            request.Resource = "/teams/{team}";
            request.AddUrlSegment("team", team);
            return Execute<TeamResponse>(request);
        }

        public TeamsResponse Teams(int limit = 25, int offset = 0)
        {
            var request = new RestRequest();
            request.Resource = "/teams";
            request.AddParameter("limit", limit, ParameterType.QueryString);
            request.AddParameter("offset", offset, ParameterType.QueryString);
            return Execute<TeamsResponse>(request);
        }

        public UserResponse User(string name)
        {
            var request = new RestRequest();
            request.Resource = "/users/{user}";
            request.AddUrlSegment("user", name);
            return Execute<UserResponse>(request);
        }

        public VideoResponse Video(string id)
        {
            var request = new RestRequest();
            request.Resource = "/videos/{id}";
            request.AddUrlSegment("id", id);
            return Execute<VideoResponse>(request);
        }

        public VideosTopResponse VideosTop(string game = "", Period type = Period.Week, int limit = 10, int offset = 0)
        {
            var request = new RestRequest();
            request.Resource = "/videos/top";
            request.AddParameter("limit", limit, ParameterType.QueryString);
            request.AddParameter("offset", offset, ParameterType.QueryString);
            request.AddParameter("period", type.ToString().ToLower(), ParameterType.QueryString);
            if (game != "")
            {
                request.AddParameter("game", game, ParameterType.QueryString);
            }
            return Execute<VideosTopResponse>(request);
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = BaseUrl;
            request.AddHeader("Accept", "application/vnd.twitchtv.v2+json");
            request.AddHeader("Client-ID", _clientId);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twitchWebApiException = new ApplicationException(message, response.ErrorException);
                throw twitchWebApiException;
            }

            return response.Data;
        }

    }
}
