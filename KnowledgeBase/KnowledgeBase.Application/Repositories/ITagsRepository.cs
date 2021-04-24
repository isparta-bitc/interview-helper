using System.Threading.Tasks;
using KnowledgeBase.Domain;

namespace KnowledgeBase.Application.Repositories
{
    public interface ITagsRepository
    {
        Task<int> AddNewTag(string name);
        Task<string[]> GetAllTagNames();
        Task<Tag> GetTagById(int id);
        Task<Tag> GetTagByName(string name);
        Task AddNewTagValues(int tagId, string[] values);
    }
}