using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOfBankAccount.Base;

namespace SystemOfBankAccount
{
    // Класс, представляющий счет подарочной карты (GiftCardAccount)
    internal class GiftCartAccount : BankAccount
    {
        // Конструктор класса, который вызывает базовый конструктор BankAccount
        public GiftCartAccount(string owner, decimal InitialBalance) : base(owner, InitialBalance)
        {
        }

        // Метод, выполняющий операции в конце месяца (например, обнуление остатка на счете)
        public override void PerformMonthEndTransaction()
            // Списание всего остатка на счете (обнуляем счет)
            => MakeWithdrawal(-Balance, DateTime.Now, ":(");
    }
}
