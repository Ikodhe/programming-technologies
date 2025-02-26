using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfBankAccount.ValueObjects
{
    // Класс, представляющий транзакцию (пополнение или снятие)
    class Transactions
    {
        public decimal Amount { get; } // Сумма транзакции
        public DateTime Date { get; } // Дата транзакции
        public string Note { get; } // Описание транзакции

        public Transactions(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }
    }
}
