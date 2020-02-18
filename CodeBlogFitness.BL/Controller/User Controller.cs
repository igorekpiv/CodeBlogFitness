using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class User_Controller
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user">Пользователь.</param>
        public User_Controller(string userName, string genderName, DateTime birthData, double weight, double height)
        {
            //TODO Проверка
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthData, weight, height);

        }     
        /// <summary>
        /// /// Получить данные пользователя.
        /// /// </summary>
        /// /// <returns>Пользователь приложения.</returns>

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("j:\\1\\users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }    



    }
}
