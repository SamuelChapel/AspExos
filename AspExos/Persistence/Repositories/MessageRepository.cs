using AspExos.Models;
using AspExos.Persistence.Context;
using AspExos.Persistence.Repositories.Base;

using Microsoft.EntityFrameworkCore;

namespace AspExos.Persistence.Repositories;

public class MessageRepository : IReadRepository<Message, int>, IWriteRepository<Message, int>
{
    private readonly ApplicationDbContext _dbContext;

    public MessageRepository(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public async Task<Message?> GetById(int id)
    {
        return await _dbContext.Messages.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<List<Message>> GetAll()
    {
        return await _dbContext.Messages.ToListAsync();
    }

    public async Task<List<Message>> FindMessages(string search)
    {
        return await _dbContext.Messages
            .Where(m => m.Emetteur.Contains(search))
            .ToListAsync();
    }

    public async Task<int> Create(Message message)
    {
        await _dbContext.Messages.AddAsync(message);

        await _dbContext.SaveChangesAsync();

        return message.Id;
    }

    public async Task Update(Message message)
    {
        _dbContext.Update(message);

        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(Message message)
    {
        _dbContext.Remove(message);

        await _dbContext.SaveChangesAsync();
    }
}
