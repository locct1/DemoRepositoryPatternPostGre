using System.ComponentModel.DataAnnotations;

namespace DemoRepositoryPattern.Dto.RoomType
{
    public class AddRoomTypeModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Max { get; set; }
    }
}
