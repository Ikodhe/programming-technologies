using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfBankAccount.ValueObjects
{
    // Структура, представляющая номер банковского счета
    struct NumberOfBankAccount
    {
        private int value; 
        public int Value { get; set; } // Публичное свойство для доступа к номеру счета

        // Конструктор, принимающий номер счета в качестве аргумента
        public NumberOfBankAccount(int value)
        {
            // Проверяем, что номер состоит ровно из 10 цифр
            if (value < 1000000000 || value >= 10000000000)
                throw new ArgumentOutOfRangeException(nameof(value), "Bank account number must be exactly 10 digits.");

            Value = value; // Присваиваем значение, если оно прошло проверку
        }
    }
}
