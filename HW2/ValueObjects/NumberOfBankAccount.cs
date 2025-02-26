using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfBankAccount.ValueObjects
{
    // Класс, представляющий номер банковского счета
    class NumberOfBankAccount
    {
        public int Value { get; } // Сделано без set, чтобы номер нельзя было менять после создания

        public NumberOfBankAccount(int value)
        {
            // Проверяем, что номер состоит из 10 цифр
            if (value < 1000000000 || value >= 10000000000)
                throw new ArgumentOutOfRangeException(nameof(value), "Bank account number must be exactly 10 digits.");
            
            Value = value;
        }
    }
}
