using GameRating_Api_App.Models;

namespace GameRating_Api_App.Data
{
    public static class GameData
    {
        public static List<Game> Ratings { get; set; } = new()
        {
            new Game
            {
                Id = 1,
                Title = "The Witcher 3",
                Developer = "CD Projekt Red",
                Year = 2015,
                Rating = 5,
                Review = "Ett fantastiskt rollspel med djup story."
            },
            new Game
            {
                Id = 2,
                Title = "Elden Ring",
                Developer = "FromSoftware",
                Year = 2022,
                Rating = 5,
                Review = "Kreativt och tidlöst spel."
            },
            new Game
            {
                Id= 3,
                Title = "Apex Legends",
                Developer = "Electronic Arts",
                Year = 2019,
                Rating = 3,
                Review = "Bra koncept"
            },
            new Game
            {
                Id= 4,
                Title = "Battlefield 6",
                Developer = "Battlefield Studios",
                Year = 2025,
                Rating = 4,
                Review = "Kul i början, men långtråkigt."
            }
        };
    }
}
