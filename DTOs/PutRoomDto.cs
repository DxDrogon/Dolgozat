using System.ComponentModel.DataAnnotations;

namespace Dolgozat.DTOs
{
    public class PutRoomDto
    {
        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
