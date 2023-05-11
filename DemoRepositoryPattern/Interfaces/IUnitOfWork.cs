namespace DemoRepositoryPattern.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRoomRepository Rooms { get; }
        IRoomTypeRepository RoomTypes { get; }
        int Save();
    }
}
