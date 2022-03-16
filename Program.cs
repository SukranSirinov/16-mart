using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user_2 = new User("Sukran");
            user_2.Password = "12Shukrans";

            User user_3 = new User("Fuad");
            user_3.Password = "12Fuadparol";

            string Username;
            string Password;
            do
            {
                Console.WriteLine("UserName :");
              Username = Console.ReadLine();
                if(HasUpper(Username) && HasLower(Username))
                {
                    break;
                }
            } while (true);
            do
            {
                Console.WriteLine("Password :");
                Password = Console.ReadLine();
                if (HasDigit(Password) && HasUpper(Password) && HasLower(Password))
                {
                    break ;
                }
            } while (true);
            User user_1 = new User(Username);
            user_1.Password = Password;
            User[] users = { user_1, user_2, user_3 };
            foreach (User user in users)
            {
                Console.WriteLine(user.GetData());
            }
        }
        string bool Hasdigit(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }

            }
            return false;
        }
        string bool HasUpper(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        string bool HasLower(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
