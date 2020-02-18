using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    [Serializable] 
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthData { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weigth { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Heigth { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthData">Дата рождения.</param>
        /// <param name="weigth">Вес.</param>
        /// <param name="heigth">Рост.</param>
        public User(string name,
                    Gender gender, 
                    DateTime birthData,
                    double weigth, 
                    double heigth)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол пользователя не может  null.", nameof(gender));
            }
            if( birthData < DateTime.Parse("01.01.1900") || birthData > DateTime.Now )                  //   
            {
                throw new ArgumentNullException("Невозможная дата рождения.", nameof(birthData));
            }
            if (weigth <= 0)
            {
                throw new ArgumentNullException("Вес пользователя не может быть меньше либо равен нулю.", nameof(weigth));
            }
            if(heigth <= 0) 
            {
                throw new ArgumentNullException("Рост пользователя не может быть меньше либо равен нулю.", nameof(heigth));
            }

            #endregion
            Name = name;
            Gender = gender;
            BirthData = birthData;
            Weigth = weigth;
            Heigth = heigth;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
