using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfBankAccount.ValueObjects
{
    // Структура, представляющая транзакцию (пополнение или снятие средств)
    struct Transactions
    {
        public decimal Amount { get; } 
        public DateTime Date { get; } 
        public string Note { get; } // Описание транзакции (например, "Снятие в банкомате" или "Пополнение")

        // Конструктор, принимающий сумму, дату и описание транзакции
        public Transactions(decimal amount, DateTime date, string note)
        {
            Amount = amount; 
            Date = date; 
            Note = note; 
        }

        // Переопределенный метод ToString() для удобного отображения информации о транзакции
        public override string ToString()
        {
            return $"Date: {Date}\tAmount: {Amount}\tNote: {Note}";
        }
    }
}
