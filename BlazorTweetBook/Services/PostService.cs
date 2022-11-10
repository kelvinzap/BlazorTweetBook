using BlazorTweetBook.Data;
using BlazorTweetBook.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorTweetBook.Services;

public class PostService : IPostService
{
    private readonly DataContext _dataContext;

    public PostService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> CreateAsync(Post post)
    {
        await _dataContext.Posts.AddAsync(post);
        var created = await _dataContext.SaveChangesAsync();
            
        return created > 0;
    }

    public async Task<IEnumerable<Post>> GetAllAsync()
    {
        return await _dataContext.Posts.ToListAsync();
    }
}