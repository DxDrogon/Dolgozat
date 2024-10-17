using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Dolgozat.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public string? UserId { get; set; }

        [JsonIgnore]
        public virtual AppUser? User { get; set; }
        
    }
}
