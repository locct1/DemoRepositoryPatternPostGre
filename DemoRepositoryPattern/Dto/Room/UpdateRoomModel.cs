using System.ComponentModel.DataAnnotations;

namespace DemoRepositoryPattern.Dto.Room
{
    public class UpdateRoomModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? RoomTypeId { get; set; }
    }
}
