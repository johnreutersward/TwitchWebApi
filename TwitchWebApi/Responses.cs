using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchWebApi
{
    public class GamesTopResponse
    {
        public int Total { get; set; }
        public Links Links { get; set; }
        public List<TopGame> Top { get; set; }
    }

    public class SearchGamesResponse
    {
        public Links Links { get; set; }
        public List<Game> Games { get; set; }

    }

    public class IngestsResponse
    {
        public Links Links { get; set; }
        public List<Ingest> Ingests { get; set; }

    }

    public class TeamsResponse
    {
        public Links Links { get; set; }
        public List<Team> Teams { get; set; }
    }

    public class TeamResponse : Team { }

    public class UserResponse : User { }

    public class VideoResponse : Video { }

    public class VideosTopResponse
    {
        public Links Links { get; set; }
        public List<Video> Videos { get; set; }
    }

    public class ErrorResponse
    {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
