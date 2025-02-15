using System;
using Domain.Entity;
using Domain;
using Domain.Enum;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        MessageHelper.ShowColoredMessage("=== MyConsoleNet ===", ConsoleColor.Cyan);
        while (true)
        {
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Войти");
            Console.WriteLine("3. Отправить сообщение");
            Console.WriteLine("4. Просмотреть сообщения");
            Console.WriteLine("5. Сменить статус");
            Console.WriteLine("6. Выход");
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    System.Console.Write("Enter username for register: ");
                    string s = Console.ReadLine();
                    SocialNetwork.RegisterUser(s);
                    break;
                case 2:
                    System.Console.Write("Enter username for login: ");
                    s = Console.ReadLine();
                    SocialNetwork.Login(s);
                    break;
                case 3:
                    System.Console.WriteLine("Enter massage: ");
                    s = Console.ReadLine();
                    System.Console.WriteLine("Choose kind of message: \n1. Image\t2. Sticker\t3. Text");
                    int n = int.Parse(Console.ReadLine());
                    MessageType messageType = MessageType.Text;
                    switch (n)
                    {
                        case 1:
                            messageType = MessageType.Image;
                            break;
                        case 2:
                            messageType = MessageType.Sticker;
                            break;
                        case 3:
                            messageType = MessageType.Text;
                            break;
                        default:
                            messageType = MessageType.Text;
                            break;
                    }
                    SocialNetwork.SendMessage(s, messageType);
                    break;
                case 4:
                    System.Console.WriteLine("Enter count of messages do you want to see: ");
                    n = int.Parse(Console.ReadLine());
                    System.Console.WriteLine(string.Join("\n", SocialNetwork.GetLastMessages(n)));
                    break;
                case 5:
                    System.Console.WriteLine("Choose kind of status: \n1. Away\t2. Offline\t3. OnLine");
                    n = int.Parse(Console.ReadLine());
                    UserStatus userStatus = UserStatus.Away;
                    switch (n)
                    {
                        case 1:
                            userStatus = UserStatus.Away;
                            break;
                        case 2:
                            userStatus = UserStatus.Offline;
                            break;
                        case 3:
                            userStatus = UserStatus.Online;
                            break;
                        default:
                            userStatus = UserStatus.Away;
                            break;
                    }
                    SocialNetwork.ChangeUserStatus(userStatus);
                    break;
                    case 6:
                    return;
                default:
                System.Console.WriteLine("Enter correct variant!");
                    break;
            }

        }

    }
}