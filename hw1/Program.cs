using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_classes.Class
{

    class Human
    {
        // Конструктор по умолчанию, инициализирует поля стандартными значениями
        public Human()
        {
            Height = 0;
            Weight = 0;
            Birthday = DateTime.Now;
            FirstName = "Name";
            LastName = "No";
        }

        // Конструктор с параметрами
        public Human(int Height_, int Weight_, DateTime Birthday_, string FirstName_, string LastName_)
        {
            bool flag = IntValidator.Validate(Height_);
            if (!flag)
            {
                Console.WriteLine("Вы указали с ошибкой параметр Heght"); // Опечатка: "Heght" → "Height"
            }
            else
            {
                Height = Height_;
            }

            flag = IntValidator.Validate(Weight_);
            if (!flag)
            {
                Console.WriteLine("Вы указали с ошибкой параметр Weght"); // Опечатка: "Weght" → "Weight"
            }
            else
            {
                Weight = Weight_;
            }

            if (Birthday_ > DateTime.Now)
            {
                Console.WriteLine("Вы указали с ошибкой параметр Birthday");
            }
            else
            {
                Birthday = Birthday_;
            }

            flag = StringValidator.Validate(FirstName_);
            if (flag)
            {
                Console.WriteLine("Вы указали с ошибкой параметр FirstName");
            }
            else
            {
                FirstName = FirstName_;
            }

            flag = StringValidator.Validate(LastName_);
            if (flag)
            {
                Console.WriteLine("Вы указали с ошибкой параметр LastName");
            }
            else
            {
                LastName = LastName_;
            }
        }

        // Свойства с доступом только на чтение или изменение внутри класса
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public DateTime Birthday { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        // Свойство для получения полного имени
        public string FullName => FirstName + " " + LastName;

        // Методы для изменения характеристик с валидацией
        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Указан некорректный рост.");
            }
            return flag;
        }

        public bool ChangeWeight(int weight)
        {
            bool flag = IntValidator.Validate(weight);
            if (flag)
            {
                this.Weight = weight;
            }
            else
            {
                Console.WriteLine("Указан некорректный вес.");
            }
            return flag;
        }

        public bool ChangeFirstName(string FirstName)
        {
            bool flag = StringValidator.Validate(FirstName);
            if (flag)
            {
                this.FirstName = FirstName;
            }
            else
            {
                Console.WriteLine("Указано некорректное имя.");
            }
            return flag;
        }

        public bool ChangeLastName(string LastName)
        {
            bool flag = StringValidator.Validate(LastName);
            if (flag)
            {
                this.LastName = LastName;
            }
            else
            {
                Console.WriteLine("Указана некорректная фамилия.");
            }
            return flag;
        }
    }

}