using BlazorTweetBook.Domain;

namespace BlazorTweetBook.Services;

public interface IPostService
{
    Task<bool> CreateAsync(Post post);
    Task<IEnumerable<Post>> GetAllAsync();
}