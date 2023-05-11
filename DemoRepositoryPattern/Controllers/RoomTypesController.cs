using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Dto.RoomType;
using DemoRepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoRepositoryPattern.Controllers
{
    [Route("api/roomtypes")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GellAllRoomtypes()
        {
            var roomtypes = _unitOfWork.RoomTypes.GetAll();
            return Ok(roomtypes);

        }
        [HttpGet("{id}")]
        public IActionResult GetRoomTypeById(int id)
        {
            var roomtype = _unitOfWork.RoomTypes.GetById(id);
            return Ok(roomtype);

        }
        [HttpPost]
        public IActionResult CreateRoomType(AddRoomTypeModel model)
        {
            RoomType roomtype = new RoomType
            {
                Name = model.Name,
                Price = model.Price,
                Max = model.Max,


            };
            _unitOfWork.RoomTypes.Add(roomtype);

            _unitOfWork.Save();
            return Ok();

        }

        [HttpPut("id")]
        public IActionResult UpdateRoomType(int id, RoomType model)
        {
            RoomType roomtype = new RoomType
            {
                Id = id,
                Name = model.Name,
                Price = model.Price,
                Max = model.Max,
            };

            if (id != roomtype.Id)
            {
                return BadRequest();

            }
            _unitOfWork.RoomTypes.Update(roomtype);
            _unitOfWork.Save();
            return Ok();

        }
        [HttpDelete("id")]
        public IActionResult DeleteRoomType(int id)
        {
            _unitOfWork.RoomTypes.Delete(id);
            _unitOfWork.Save();
            return Ok();

        }
    }
}
