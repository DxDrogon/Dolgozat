using System.ComponentModel.DataAnnotations;

namespace Dolgozat.DTOs
{
    public class GetRoomDto
    {
        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
