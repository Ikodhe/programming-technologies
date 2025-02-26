using System;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем первый банковский счет
            var account1 = new BankAccount("Full", 1000);
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance");

            // Создаем второй банковский счет
            var account2 = new BankAccount("Asw", 2000);
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial balance");

            // Пополняем первый счет
            account1.MakeDeposit(100m, DateTime.Now, "Adidas");
            account1.MakeDeposit(20000m, DateTime.Now, "Adidas");

            // Снимаем деньги со счета
            account1.MakeWithdrawal(5000m, DateTime.Now, "Fila");

            // Выводим текущий баланс после операций
            Console.WriteLine($"Account {account1.Number.Value} now has {account1.Balance} balance");
        }
    }
}
