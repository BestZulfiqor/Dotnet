using System;
using infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Post post1 = new Post("The weather", "The Dushanbe's weather is good", 1);
        Post post2 = new Post("The weather", "The Khujand's weather is too windy",1);
        Category category = new Category("Weather", DateTime.Now, 1);
        Manager manager = new Manager();
        post1.CreateAt = DateTime.Now;
        post2.CreateAt = DateTime.Today;
        manager.AddPost(post1);
        manager.AddPost(post2);
        List<Post> posts = manager.GetPostsByName("The weather");
        foreach (var item in posts)
        {
            System.Console.WriteLine($"Title: {item.Title} Description: {item.Description}");
        }

        List<Post> postsByDate = manager.GetPostsByDate(DateTime.Today);
        foreach (var item in postsByDate)
        {
            System.Console.WriteLine($"Title: {item.Title} Description: {item.Description}");
        }

        manager.DeletePost(1);
        foreach (var item in manager.GetPosts())
        {
            System.Console.WriteLine($"Title: {item.Title} Description: {item.Description}");
        }

        Post post = manager.GetPostById(2);
        System.Console.WriteLine($"Title: {post.Title} Description: {post.Description}");
    }
}