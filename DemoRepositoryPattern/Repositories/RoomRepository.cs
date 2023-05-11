using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Interfaces;

namespace DemoRepositoryPattern.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(AppDbContext context) : base(context)
        {
        }
    }
}
