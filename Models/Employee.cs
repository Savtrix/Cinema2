using Cinema.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
namespace Cinema.Models
{
    [Authorize]
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string Employee_Name { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string Employee_Surename { get; set; }
        public string Employee_Position { get; set; }
       
        
        
        
    }
}
