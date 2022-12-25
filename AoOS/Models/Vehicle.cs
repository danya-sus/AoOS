using System.ComponentModel.DataAnnotations;

namespace AoOS.Models
{
    public class Vehicle
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
