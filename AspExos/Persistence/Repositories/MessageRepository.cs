using AspExos.Models;
using AspExos.Persistence.Context;
using AspExos.Persistence.Repositories.Base;

namespace AspExos.Persistence.Repositories;

public class MessageRepository : IReadRepository<Message, int>
{
    private readonly ApplicationDbContext _context;

    public MessageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Message?> GetById(int id)
    {
        return _context.Messages.FirstOrDefault(m => m.Id == id);

    }

    public async Task<IEnumerable<Message>> GetAll()
    {
        throw new NotImplementedException();
    }
}
