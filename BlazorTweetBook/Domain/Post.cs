using System.ComponentModel.DataAnnotations;

namespace BlazorTweetBook.Domain;

public class Post
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
}