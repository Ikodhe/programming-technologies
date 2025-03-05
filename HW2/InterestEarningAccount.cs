using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOfBankAccount.Base;

namespace SystemOfBankAccount
{
    // Класс, представляющий кредитную линию (Line of Credit Account)
    internal class LineOfCreditAccount : BankAccount
    {
        // Конструктор класса, вызывающий конструктор базового класса BankAccount
        public LineOfCreditAccount(string owner, decimal InitialBalance) : base(owner, InitialBalance)
        {
        }

        // Метод, выполняющий операции в конце месяца (например, начисление процентов)
        public override void PerformMonthEndTransaction()
        {
            // Проверяем, находится ли баланс в отрицательной зоне (есть ли задолженность)
            if (Balance < 0)
            {
                // Начисляем проценты на задолженность (7% от текущего отрицательного баланса)
                MakeWithdrawal(-Balance * 0.07m, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
