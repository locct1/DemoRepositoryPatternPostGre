using System.ComponentModel.DataAnnotations;

namespace DemoRepositoryPattern.Dto.Category
{
    public class UpdateRoomTypeModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Max { get; set; }
    }
}
