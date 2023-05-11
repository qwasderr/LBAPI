using System.ComponentModel.DataAnnotations;
namespace LBAPI.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
