using System;
using SystemOfBankAccount;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание счета с начислением процентов (InterestEarningAccount)
            var account1 = new InterestEarningAccount("Adidas", 10000);
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance.");

            // Пополнение счета account1
            account1.MakeDeposit(1000m, DateTime.Now, "fila");
            account1.MakeDeposit(20m, DateTime.Now, "puma");

            // Снятие средств со счета account1
            account1.MakeWithdrawal(10m, DateTime.Now, "columbia");

            // Создание кредитного счета (LineOfCreditAccount)
            var account2 = new LineOfCreditAccount("nike", 14300);
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial balance.");

            // Пополнение счета account2
            account2.MakeDeposit(1000m, DateTime.Now, "fila");
            account2.MakeDeposit(20m, DateTime.Now, "puma");

            // Вывод истории транзакций для обоих счетов
            Console.WriteLine(account1.GetAccountHistory());
            Console.WriteLine(account2.GetAccountHistory());

            try
            {
                // Попытка снять 2000 со счета account1
                account1.MakeWithdrawal(2000m, DateTime.Now, "myaso");
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Обработка исключения при передаче некорректного аргумента (например, отрицательной суммы)
                Console.WriteLine(e.Message, e.ParamName);
            }
            catch (InvalidOperationException e)
            {
                // Обработка исключения, если на счете недостаточно средств
                Console.WriteLine(e.Message, e.ToString);
            }
            catch (ArgumentException e)
            {
                // Обработка других возможных исключений
                Console.WriteLine(e.Message, e.ToString);
            }
        }
    }
}
