using System;
using System.Collections.Generic;
using System.Transactions;
using SystemOfBankAccount.ValueObjects;

namespace SystemOfBankAccount
{
    // Класс, представляющий банковский счет
    class BankAccount
    {
        private List<Transactions> _allTransactions = new List<Transactions>(); // Список всех транзакций

        private static int s_accountNumberSeed = 1000000000; // Начальный номер счета
        public NumberOfBankAccount Number { get; } // Уникальный номер счета

        public string Owner { get; set; } // Владелец счета

        // Свойство для вычисления текущего баланса
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        // Конструктор для создания счета с начальным балансом
        public BankAccount(string owner, decimal initialBalance)
        {
            Number = new NumberOfBankAccount(s_accountNumberSeed); // Генерируем номер счета
            Owner = owner;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance"); // Делаем начальный депозит
        }

        // Метод для внесения депозита
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");

            var deposit = new Transactions(amount, date, note);
            _allTransactions.Add(deposit);
        }

        // Метод для снятия средств
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");

            if (Balance - amount < 0)
                throw new InvalidOperationException("Not sufficient funds for this transaction.");

            var withdrawal = new Transactions(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }
    }
}