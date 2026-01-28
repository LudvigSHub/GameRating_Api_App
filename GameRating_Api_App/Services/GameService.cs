using GameRating_Api_App.Data;
using GameRating_Api_App.Models;

namespace GameRating_Api_App.Services
{
    public class GameService
    {
        public List<Game> GetAll()
        {
            return GameData.Ratings;
        }

        public Game GetById(int id)
        {
            return GameData.Ratings.FirstOrDefault(g => g.Id == id);
        }

        public Game Add(Game rating)
        {
            rating.Id = GameData.Ratings.Max(g => g.Id) + 1;
            GameData.Ratings.Add(rating);
            return rating;
        }

        public Game Update(int id, Game updated)
        {
            var existing = GetById(id);
            if (existing == null)
                return null;

            existing.Title = updated.Title;
            existing.Developer = updated.Developer;
            existing.Year = updated.Year;
            existing.Rating = updated.Rating;
            existing.Review = updated.Review;

            return existing;
        }

        public bool Delete(int id)
        {
            var rating = GetById(id);
            if (rating == null)
                return false;

            GameData.Ratings.Remove(rating);
            return true;
        }
    }
}
