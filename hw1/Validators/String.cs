using System;
using System.Text.RegularExpressions;

namespace HW1_classes
{
    class StringValidator
    {
        static public bool Validate(string Value)
        {
            // Проверяем, является ли строка пустой или содержащей только пробелы
            if (string.IsNullOrWhiteSpace(Value))
            {
                return false;
            }

            // Проверяем, состоит ли строка только из латинских букв (ошибка в логике)
            if (Regex.IsMatch(Value, @"^[a-zA-Z]+$"))
            {
                return false; // Здесь, скорее всего, ошибка: валидные имена наоборот должны соответствовать этому шаблону
            }

            return true; // Если строка не пустая и содержит не только латинские буквы, считается валидной
        }
    }
}