using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOfBankAccount.Base;

namespace SystemOfBankAccount
{
    // Класс, представляющий счет с начислением процентов
    class InterestEarningAccount : BankAccount
    {
        // Конструктор, вызывающий базовый конструктор BankAccount
        public InterestEarningAccount(string owner, decimal InitialBalance) : base(owner, InitialBalance)
        {
        }

        // Переопределенный метод для выполнения операций в конце месяца
        public override void PerformMonthEndTransaction()
        {
            // Проверяем, превышает ли баланс 500
            if (Balance > 500m)
            {
                // Рассчитываем сумму процентов (2% от баланса)
                decimal interest = Balance + 0.02m;

                // Добавляем начисленные проценты в виде депозита
                MakeDeposit(interest, DateTime.Now, "Apply monthly interest.");
            }
        }
    }
}
