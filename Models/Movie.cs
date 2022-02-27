using System.ComponentModel.DataAnnotations;
namespace Cinema.Models
{

    public class Movie
    {

        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }
        public DateTime PlayDate { get; set; }
        [Range(0,10, ErrorMessage = "We have only 10 rooms :/")]
        public int RoomId { get; set; }
        
        public int ProjectionistId { get; set; }
        
    
    }
}
