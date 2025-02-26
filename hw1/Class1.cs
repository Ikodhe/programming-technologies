using System;
using System.Security.Cryptography;
using HW1_classes.Class;


namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new
            DateTime(2005, 11, 17);

            // Создаем объект класса Human с указанными параметрами
            Human human = new
            Human(175, 84, birthday, "Politakhin", "Konstantin");
            Console.WriteLine($"Человек: {human.FullName}, Дата рождения: {human.Birthday}, Рост: {human.Height}, Вес: {human.Weight}");
        }
    }

}