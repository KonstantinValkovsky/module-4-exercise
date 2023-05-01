using System.Security.Cryptography.X509Certificates;

namespace module_4_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Surname, string Login, int CountLogin, bool HasPet, double Age, string[] favcolors ) Anketa;

            for (int k = 0; k < 3; k++)
            {
                Console.Write("Введите имя: ");
                Anketa.Name = Console.ReadLine();

                Console.Write("Введите фамилию :");
                Anketa.Surname = Console.ReadLine();

                Console.Write("Ввведите логин: ");
                Anketa.Login = Console.ReadLine();
                Anketa.CountLogin = Anketa.Login.Length;

                Console.WriteLine("Есть ли у вас животное? ДА или Нет");
                var result = Console.ReadLine();

                if (result == "Да")
                {
                    Anketa.HasPet = true;
                }
                else
                {
                    Anketa.HasPet = false;
                }

                Console.Write("Введите возраст пользователя: ");
                Anketa.Age = double.Parse(Console.ReadLine());

                Anketa.favcolors = new string[3];
                Console.WriteLine("Введите три своих любимых цвета: ");
                for (int i = 0; i < Anketa.favcolors.Length; i++)
                {
                    Anketa.favcolors[i] = Console.ReadLine();
                }
            }


            Console.ReadKey();
        }

    }
}