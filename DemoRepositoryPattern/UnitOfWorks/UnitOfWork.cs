using DemoRepositoryPattern.Data;
using DemoRepositoryPattern.Interfaces;
using DemoRepositoryPattern.Repositories;

namespace DemoRepositoryPattern.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRoomRepository Rooms { get; private set; }
        public IRoomTypeRepository RoomTypes { get; private set; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Rooms = new RoomRepository(_context);
            RoomTypes = new RoomTypeRepository(_context);
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
