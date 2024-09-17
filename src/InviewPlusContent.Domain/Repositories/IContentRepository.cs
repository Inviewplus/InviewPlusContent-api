using InviewPlusContent.Domain.Entities;

namespace InviewPlusContent.Domain.Repositories;

public interface IContentRepository
{
    Task<IEnumerable<Content>> GetAllAsync();
    Task<Content> GetByIdAsync(int id);
    Task AddAsync(Content content);
    Task UpdateAsync(Content content);
    Task DeleteAsync(int id);
}