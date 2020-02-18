using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");

            Console.WriteLine("Введите имя пользователя ");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения ");
            var birthData = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес ");
            var weight= double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост ");
            var height = double.Parse(Console.ReadLine());

            var userController = new User_Controller(name, gender, birthData, weight, height);
            userController.Save();

        }
    }
}
