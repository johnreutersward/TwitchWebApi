using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchWebApi
{
    public class GamesTopResponse : ErrorResponse
    {
        public int Total { get; set; }
        public Links Links { get; set; }
        public List<TopGame> Top { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class SearchGamesResponse : ErrorResponse
    {
        public Links Links { get; set; }
        public List<Game> Games { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }

    }

    public class IngestsResponse : ErrorResponse
    {
        public Links Links { get; set; }
        public List<Ingest> Ingests { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }

    }

    public class TeamsResponse : ErrorResponse
    {
        public Links Links { get; set; }
        public List<Team> Teams { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class TeamResponse : Team, ErrorResponse
    {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }


    public class UserResponse : User, ErrorResponse  {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class StreamResponse : Stream, ErrorResponse
    {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class FeaturedStreamResponse : FeaturedStream, ErrorResponse
    {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class VideoResponse : Video, ErrorResponse {
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class VideosTopResponse : ErrorResponse
    {
        public Links Links { get; set; }
        public List<Video> Videos { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public interface ErrorResponse
    {
        string Error { get; set; }
        int Status { get; set; }
        string Message { get; set; }
    }
}
