using Domain;
using Infrastructure;

MediumStore mediumStore = new MediumStore();
bool isVerifed = false;
while (true)
{
    try
    {
        if (isVerifed)
        {
            System.Console.WriteLine("Menu:");
            System.Console.WriteLine("1. Get all articles");
            System.Console.WriteLine("2. Add article");
            System.Console.WriteLine("3. Update article");
            System.Console.WriteLine("4. Delete article");
            System.Console.WriteLine("5. Get articles by category");
            System.Console.WriteLine("6. Get articles by author");
            System.Console.WriteLine("7. Logout");
            System.Console.WriteLine("8. Exit");
        }
        else
        {
            System.Console.WriteLine("10. Register");
            System.Console.WriteLine("20. Login");
        }
        int n = int.Parse(System.Console.ReadLine());
        switch (n)
        {
            case 1:
                var articles = mediumStore.GetAllArticles();
                foreach (var article in articles)
                {
                    System.Console.WriteLine($"{article.ID} {article.Title}");
                    System.Console.WriteLine($"{article.Content}");
                    System.Console.WriteLine();
                }
                break;
            case 2:
                System.Console.WriteLine("Enter article title, content, author id, category id, likes count, dislikes count, comments count");
                System.Console.Write("Article title: ");
                string title = System.Console.ReadLine();
                System.Console.Write("Article content: ");
                string content = System.Console.ReadLine();
                System.Console.Write("Author id: ");
                int authorId = int.Parse(System.Console.ReadLine());
                System.Console.Write("Category id: ");
                int categoryId = int.Parse(System.Console.ReadLine());
                System.Console.Write("Likes count: ");
                Article newArticle = new Article("Title", "Content", 24, 2, 0, 0, 5);
                bool res = mediumStore.PublishArticle(newArticle);
                if (res) System.Console.WriteLine("Article added");
                else { System.Console.WriteLine("Error"); }
                break;
            case 3:
                Article updateArticle = new Article("Title", "Content", 24, 2, 0, 0, 5);
                updateArticle.ID = 1;
                bool updateResult = mediumStore.PublishArticle(updateArticle);
                if (updateResult) System.Console.WriteLine("Article updated");
                else { System.Console.WriteLine("Error"); }
                break;
            case 4:
                int deleteId = int.Parse(System.Console.ReadLine());
                var deleteResult = mediumStore.DeleteArticle(deleteId);
                if (deleteResult) System.Console.WriteLine("Article deleted");
                else { System.Console.WriteLine("Error"); }
                break;
            case 5:
                System.Console.Write("Enter category id: ");
                int categoryId = int.Parse(System.Console.ReadLine());
                var articlesByCategory = mediumStore.GetArticlesByCategory(categoryId);
                foreach (var article in articlesByCategory)
                {
                    System.Console.WriteLine($"Id: {article.ID}. {article.Title}, {article.Content}");
                }
                System.Console.WriteLine();
                break;
            case 6:
                System.Console.Write("Enter author id: ");
                int authorId = int.Parse(System.Console.ReadLine());
                var articlesByAuthor = mediumStore.GetArticlesByAuthor(authorId);
                foreach (var article in articlesByAuthor)
                {
                    System.Console.WriteLine($"Id: {article.ID}. {article.Title}, {article.Content}");
                }
                System.Console.WriteLine();
                break;
            case 7:
                isVerifed = false;
                System.Console.WriteLine("Logout success");
                break;
            case 8:
                return;
            case 10:
                Reader reader = new Reader(name: "", email: "", password: "");
                System.Console.Write("Enter name: ");
                reader.Name = System.Console.ReadLine();
                System.Console.Write("Enter email: ");
                reader.Email = System.Console.ReadLine();
                System.Console.Write("Enter password: ");
                reader.Password = System.Console.ReadLine();
                var RegisterUser = mediumStore.RegisterUser(reader);
                if (RegisterUser)
                    isVerifed = true;
                else { System.Console.WriteLine("Registration failed"); }
                break;
            case 20:
                System.Console.WriteLine("Enter email and password for login");
                System.Console.Write("Email:");
                string email = System.Console.ReadLine();
                System.Console.Write("Password:");
                string password = System.Console.ReadLine();
                var loginResult = mediumStore.Login(email, password);
                if (loginResult)
                    isVerifed = true;
                else { System.Console.WriteLine("Error"); }
                break;
            default:
                System.Console.WriteLine("I don`t know this command");
                break;
        }
    }
    catch (Exception exception)
    {
        System.Console.WriteLine(exception.Message);
    }
}