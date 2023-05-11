using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoRepositoryPattern.Dto.Room
{
    public class AddRoomModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? RoomTypeId { get; set; }
    }
}
