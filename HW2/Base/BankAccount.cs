using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SystemOfBankAccount.ValueObjects;

namespace SystemOfBankAccount.Base
{
    // Класс, представляющий банковский счет
    abstract class BankAccount
    {
        private List<Transactions> _allTransactions = new List<Transactions>(); // Список всех транзакций, связанных с этим счетом

        private static int s_accountNumberSeed = 1000000000; // Начальный номер счета, будет увеличиваться с каждым новым счетом
        public NumberOfBankAccount Number { get; } // Уникальный номер счета, генерируемый при создании

        public string Owner { get; set; } // Владелец счета

        // Свойство для вычисления текущего баланса на основе всех транзакций
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions) // Проходим по всем транзакциям
                {
                    balance += item.Amount; // Суммируем все суммы транзакций
                }
                return balance; // Возвращаем итоговый баланс
            }
        }

        // Конструктор для создания счета с указанием владельца и начального баланса
        public BankAccount(string owner, decimal initialBalance)
        {
            Number = new NumberOfBankAccount(s_accountNumberSeed); // Присваиваем номер счета
            s_accountNumberSeed++; // Увеличиваем счетчик номеров для следующего счета
            Owner = owner; // Устанавливаем владельца
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance"); // Делаем начальный депозит
        }

        // Метод для внесения депозита
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) // Проверяем, что сумма положительная
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");

            var deposit = new Transactions(amount, date, note); // Создаем объект транзакции для депозита
            _allTransactions.Add(deposit); // Добавляем транзакцию в список
        }

        // Метод для снятия средств со счета
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) // Проверяем, что сумма снятия положительная
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");

            if (Balance - amount < 0) // Проверяем, хватает ли средств на счете
                throw new InvalidOperationException("Not sufficient funds for this transaction.");

            var deposit = new Transactions(-amount, date, note); // Создаем объект транзакции для снятия средств
            _allTransactions.Add(deposit); // Добавляем транзакцию в список
        }

        // Метод для получения истории всех транзакций счета
        public string GetAccountHistory()
        {
            var str = new StringBuilder(); // Используем StringBuilder для эффективной работы со строками
            foreach (var elem in _allTransactions) // Перебираем все транзакции
                str.AppendLine(elem.ToString()); // Добавляем строковое представление транзакции в историю

            return str.ToString(); // Возвращаем сформированную строку с историей транзакций
        }

        // Абстрактный метод, который должен быть реализован в производных классах,
        public abstract void PerformMonthEndTransaction();
    }
}
