namespace NotifyBot.Domain.Models.Interfaces
{
    public interface IUnitOfWork
    {
        void Complete();
        Task CompleteAsync();
    }
}
