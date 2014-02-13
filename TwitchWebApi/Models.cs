using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchWebApi
{
    public class TopGame
    {
        public int Viewers { get; set; }
        public int Channels { get; set; }
        public Game Game { get; set; }

    }

    public class Game
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int? Popularity { get; set; }
        public int GiantbombId { get; set; }
        public GameBox Box { get; set; }
        public GameLogo Logo { get; set; }
        public GameLinks Links { get; set; }
        public GameImages Images { get; set; }
    }

    public class GameBox
    {
        public string Template { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
    }

    public class GameLogo
    {
        public string Template { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
    }

    public class GameLinks
    {
        public string Value { get; set; }
    }

    public class GameImages
    {
        public string Thumb { get; set; }
        public string Tiny { get; set; }
        public string Small { get; set; }
        public string Super { get; set; }
        public string Medium { get; set; }
        public string Icon { get; set; }
        public string Screen { get; set; }
    }

    public class Links
    {
        public string Self { get; set; }
        public string Next { get; set; }
    }

    public class VideoLinks
    {
        public string Self { get; set; }
        public string Channel { get; set; }
    }

    public class Ingest
    {
        public string Name { get; set; }
        public bool Default { get; set; }
        public int Id { get; set; }
        public string UrlTemplate { get; set; }
        public float Availability { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Info { get; set; }
        public string Background { get; set; }
        public string Banner { get; set; }
        public string Logo { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
    }

    public class Video
    {
        public DateTime RecordedAt { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public string BroadcastId { get; set; }
        public VideoLinks Links { get; set; }
        public int Views { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public string Game { get; set; }
        public string Preview { get; set; }

        public Channel Channel { get; set; }


    }

    public class Channel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Logo { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public Links Links { get; set; }
    }




}
