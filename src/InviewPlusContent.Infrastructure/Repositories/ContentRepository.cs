using InviewPlusContent.Domain.Entities;
using InviewPlusContent.Domain.Repositories;
using InviewPlusContent.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace InviewPlusContent.Infrastructure.Repositories;

public class ContentRepository : IContentRepository
{
    private readonly ContentDbContext _context;

    public ContentRepository(ContentDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Content>> GetAllAsync()
    {
        return await _context.Contents
            .Include(c => c.Seasons)
            .ThenInclude(s => s.Episodes)
            .ToListAsync();
    }

    public async Task<Content> GetByIdAsync(int id)
    {
        return await _context.Contents
            .Include(c => c.Seasons)
            .ThenInclude(s => s.Episodes)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddAsync(Content content)
    {
        _context.Contents.Add(content);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Content content)
    {
        _context.Contents.Update(content);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var content = await _context.Contents.FindAsync(id);
        if (content != null)
        {
            _context.Contents.Remove(content);
            await _context.SaveChangesAsync();
        }
    }

}