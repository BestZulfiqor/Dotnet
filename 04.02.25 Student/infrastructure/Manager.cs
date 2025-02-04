namespace infrastructure;

public class Manager
{
    List<Post> posts = new List<Post>();
    List<Category> categories = new List<Category>();
    public void AddPost(Post post)
    {
        posts.Add(post);
    }
    public List<Post> GetPosts()
    {
        return posts;
    }
    public Post? GetPostById(int Id)
    {
        foreach (var item in posts)
        {
            if (item.ID == Id)
            {
                return item;
            }
        }
        return null;
    }
    public List<Post> GetPostsByName(string name)
    {
        List<Post> posts2 = new List<Post>();
        foreach (var item in posts)
        {
            if (item.Title == name)
            {
                posts2.Add(item);
            }
        }
        return posts2;
    }
    public List<Post> GetPostsByDate(DateTime date)
    {
        List<Post> posts2 = new List<Post>();
        foreach (var item in posts)
        {
            if (item.CreateAt == date)
            {
                posts2.Add(item);
            }
        }
        return posts2;
    }
    public List<Post> GetPostsByCategoryId(int id)
    {
        List<Post> posts2 = new List<Post>();
        foreach (var item in posts)
        {
            if (item.CategoryId == id)
            {
                posts2.Add(item);
            }
        }
        return posts2;
    }
    public void DeletePost(int id)
    {
        bool found = false;
        foreach (var item in posts)
        {
            if (item.ID == id)
            {
                found = true;
                posts.Remove(item);
                System.Console.WriteLine("Post deleted!");
                return;
            }
        }
        if (!found)
        {
            System.Console.WriteLine("Id not found!");
        }
    }

    public List<Category> GetCategories()
    {
        return categories;
    }
    public Category? GetCategoryById(int id)
    {
        foreach (var item in categories)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    public Category? GetCategoryByName(string name)
    {
        foreach (var item in categories)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        return null;
    }
    public List<Category> GetCategoryByDate(DateTime date)
    {
        List<Category> categories2 = new List<Category>();
        foreach (var item in categories)
        {
            if (item.CreatAt == date)
            {
                categories2.Add(item);
            }
        }
        return categories2;
    }
    public void DeleteCategory(int id)
    {
        bool found = false;
        foreach (var item in categories)
        {
            if (item.Id == id)
            {
                categories.Remove(item);
            }
        }
        if (!found)
        {
            System.Console.WriteLine("Id not found!");
        }
    }
}
