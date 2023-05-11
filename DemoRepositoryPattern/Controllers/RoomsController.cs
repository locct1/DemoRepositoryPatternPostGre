using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Dto.Room;
using DemoRepositoryPattern.Dto.Room;
using DemoRepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoRepositoryPattern.Controllers
{
    [Route("api/rooms")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GellAllRooms()
        {
            //var rooms = _unitOfWork.Rooms.GetAll(room => room.Name == "Iphone 13", includeProperties: "Category");
            //var rooms = _unitOfWork.Rooms.GetAll(orderBy: q => q.OrderBy(p => p.Price), includeProperties: "Category");
            var rooms = _unitOfWork.Rooms.GetAll(includeProperties: "RoomType");
            return Ok(rooms);

        }
        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var room = _unitOfWork.Rooms.GetById(id);
            return Ok(room);

        }
        [HttpPost]
        public IActionResult CreateRoom(AddRoomModel model)
        {
            var room = new Room
            {
                Name = model.Name,
                Note = model.Note,
                Status = model.Status,
                RoomTypeId = model.RoomTypeId,
            };
            _unitOfWork.Rooms.Add(room);
            _unitOfWork.Save();
            return Ok();

        }

        [HttpPut("id")]
        public IActionResult UpdateRoom(int id, UpdateRoomModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();

            }
            var room = new Room
            {
                Id = id,
                Name = model.Name,
                Note = model.Note,
                Status = model.Status,
                RoomTypeId = model.RoomTypeId,
            };
            _unitOfWork.Rooms.Update(room);
            _unitOfWork.Save();
            return Ok();

        }
        [HttpDelete("id")]
        public IActionResult DeleteRoom(int id)
        {
            _unitOfWork.Rooms.Delete(id);
            _unitOfWork.Save();
            return Ok();

        }
    }
}
