using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using GameReviews.Models; /// This particular line of code gets the custom created "data" in "GameReviews" to utilize the "models" folder.
namespace Practice.Data
{
    public class GameRepository
    {
        public GameReview[] GetGames() //Defines a method which returns an array
        {
            return _listOfGames.ToArray();
        }
        
        public GameReview[][] GetGameReviewsByThree()
        {
            int i = 0;
            var groupOfThree = from GameReview in _listOfGames
                               let num = i++
                               group GameReview by num / 3 into g
                               select g.ToArray();
            return groupOfThree.ToArray();
        }

        public GameReview GetGameReview(int id)
        {
            return (from GameReview in _listOfGames
                    where GameReview.Id == id
                    select GameReview).Single();
        }

        private static List<GameReview> _listOfGames = new List<GameReview>
        {
            new GameReview
            {
                Id = 1,
                Name = "CSGO",
                Description = "CounterStrike: Global Offensive is by far one of the best competitive games on the market right now. While FPS games are not my favorite genre, the team-based tactical meta-gaming that arises from this game make it one of my all-time favorites. However, there are some drawbacks with the community, programming of the game and the rampant cheaters in the game. This simple game is easy to learn but extremely difficult to master.",
                Website = "https://store.steampowered.com/app/730/CounterStrike_Global_Offensive/",
                Stars = 4
            },

            new GameReview
            {
                Id = 2,
                Name = "Dota2",
                Description = "I've sunk plenty of hours into what I consider to be the best MOBA available to gamers. The ranked matchmaking system is the best player versus player system of any MMR system I have played. However, the deep amount of information and gameplay creates a bit of a learning curve and makes the game difficult to master.",
                Website = "https://store.steampowered.com/app/570/Dota_2/",
                Stars = 3
            },

            new GameReview
            {
                Id = 3,
                Name = "Witcher 3",
                Description = "Of the games included in this list, The Witcher 3 comes out as the clear winner. This brutal game does not hold back when immersing players in a brutal fantasy realm where demons, witches, and monsters terrorize the countryside. Players get a chance to explore a world like no other in this deep open-world RPG.",
                Website = "https://thewitcher.com/en/witcher3",
                Stars = 5
            },

            new GameReview
            {
                Id = 4,
                Name = "Mass Effect Andromeda",
                Description = "While I personally loved Mass Effect 2, and even enjoyed Mass Effect 3, Mass Effect Andromeda was a bit of a disappointment for me. The game removed a lot of the tactical features that I fell in love with in previous versious. While the game was aesthetically pleasing, the gameplay became very repetitive and the story; while promising, ultimately trailed off and became lost and rather uninspiring.",
                Website = "https://www.masseffect.com/",
                Stars = 2
            },

            new GameReview
            {
                Id = 5,
                Name = "Dragon Age Inquisition",
                Description = "I have been a BioWare and Dragonage fan for a few years now. This game was thoroughly enjoyable and I even replayed it after completing the game once. The game is just a delight to play. Though enjoyable, when compared to the Witcher 3, I have to give Dragon Age Inquisition 4 stars.",
                Website = "https://www.ea.com/games/dragon-age/dragon-age-inquisition",
                Stars = 4
            }
        };
    }
}
