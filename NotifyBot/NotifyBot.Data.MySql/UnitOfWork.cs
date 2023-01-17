using NotifyBot.Domain.Models.Interfaces;

namespace NotifyBot.Data.MySql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public Task CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
