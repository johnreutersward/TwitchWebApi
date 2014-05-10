using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwitchWebApi.Test
{
    [TestClass]
    public class TwitchWebApiTest
    {
        private TwitchWebApiClient twitch;

        [TestInitialize]
        public void Startup()
        {
            twitch = new TwitchWebApiClient("API KEY GOES HERE");
        }

        [TestMethod]
        public void TestTopGames()
        {
            
            var topGames = twitch.GamesTop();
            Assert.IsNotNull(topGames);
        }

        [TestMethod]
        public void TestSearchGames()
        {
            var sGames = twitch.SearchGames("StarCraft II: Heart of the Swarm", false);
            Assert.IsNotNull(sGames);
            Assert.AreEqual(sGames.Games[0].Name, "StarCraft II: Heart of the Swarm");

        }

        [TestMethod]
        public void TestIngests()
        {
            var ingests = twitch.Ingests();
            Assert.IsNotNull(ingests);
        }

        [TestMethod]
        public void TestTeam()
        {
            var team = twitch.Team("eg");
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public void TestStream()
        {
            var stream = twitch.Stream("twitchplayspokemon");
            Assert.IsNotNull(stream);
        }

        [TestMethod]
        public void TestFeaturedStreams()
        {
            var stream = twitch.FeaturedStreams();
            Assert.IsNotNull(stream);
            Assert.IsNotNull(stream.featured);
            Assert.IsNotNull(stream.featured[0].stream);
        }

        [TestMethod]
        public void TestTeamError()
        {
            var team = twitch.Team("TeamTwitchWebApiClientTeamTest");
            Assert.IsNotNull(team);
            Assert.AreEqual(team.Status, 404);
        }

        [TestMethod]
        public void TestTeams()
        {
            var team = twitch.Teams(1, 0);
            Assert.IsNotNull(team);

        }

        [TestMethod]
        public void TestUser()
        {
            var user = twitch.User("Adam_ak");
            Assert.IsNotNull(user);
            Assert.AreEqual(user.Id, 21521869);
        }

        [TestMethod]
        public void TestVideo()
        {
            var video = twitch.Video("a328087483");
            Assert.IsNotNull(video);
            Assert.AreEqual(video.Id, "a328087483");
        }

        [TestMethod]
        public void TestVideosTop()
        {
            var videosTop = twitch.VideosTop();
            Assert.IsNotNull(videosTop);
        }
    }
}
