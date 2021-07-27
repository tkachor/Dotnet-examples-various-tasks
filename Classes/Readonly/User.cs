using System;
using System.Collections.Generic;
using System.Text;

/* (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе. */

namespace Classes.Readonly
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        readonly DateTime data;



        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            data = data.Date;
        }

     
    }
}
