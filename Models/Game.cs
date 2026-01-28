using System.ComponentModel.DataAnnotations;

namespace GameRating_Api_App.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        [Required]
        public string Developer { get; set; }
        [Required]
        [Range(1970, 2100)]
        public int Year { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Review { get; set; }
    }
}
        

