using System.ComponentModel.DataAnnotations;

namespace Dolgozat.DTOs
{
    public class GetComputerDto
    {
        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime ManufacturedDate { get; set; }
    }
}
