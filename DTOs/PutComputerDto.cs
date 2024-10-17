using System.ComponentModel.DataAnnotations;

namespace Dolgozat.DTOs
{
    public class PutComputerDto
    {
        public string Model { get; set; }

        public DateTime ManufacturedDate { get; set; }

        public int RoomId { get; set; }
    }
}
