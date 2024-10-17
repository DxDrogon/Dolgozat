using System.ComponentModel.DataAnnotations;

namespace Dolgozat.DTOs
{
    public class PostComputerDto
    {
        public string Model { get; set; }

        public DateTime ManufacturedDate { get; set; }
    }
}
