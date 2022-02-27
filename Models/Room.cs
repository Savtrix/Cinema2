using System.ComponentModel.DataAnnotations;
namespace Cinema.Models
{
    
    public class Room
    {
        public int Id { get; set; }
       [Range(20,60)]
        public int Size { get; set; }
    }
}
