/*Cuenta bancaria: 
Tiene un número de diez dígitos que identifica la cuenta bancaria de forma única.
Tiene una cadena que almacena el nombre o los nombres de los propietarios.
Se puede consultar el saldo.
Acepta depósitos.
Acepta reintegros.
El saldo inicial debe ser positivo.
Los reintegros no pueden generar un saldo negativo.
*/
// Se agregó ArgumentNullException y ArgumentException

using System;
using System.Collections.Generic;

namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    #region BalanceComputation
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
    #endregion

    private static int s_accountNumberSeed = 1234567890;
    #region Constructor
    public BankAccount(string name, decimal initialBalance)
    {
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }
    #endregion

    #region TransactionDeclaration
    private List<Transaction> _allTransactions = new List<Transaction>();
    #endregion

    #region DepositAndWithdrawal
    public void MakeDeposit(decimal amount, DateTime date, string? note) // El ? indica que el string aceptará valores nulos
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        if (note is null)
        {
            throw new ArgumentNullException(nameof(note), "The user inserted a null value.");
        }
        if (amount == 0)
        {
            throw new ArgumentException(nameof(amount), "Amount of deposit should be greater than 0");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string? note) 
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The user did not write a note");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        if (note is null)
        {
            throw new ArgumentNullException(nameof(note), "The user inserted a null value.");
        }
        if (amount == 0)
        {
            throw new ArgumentException(nameof(amount), "Amount of deposit should be greater than 0");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    #endregion

    #region History
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();
        decimal balance = 0;
       
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }
    #endregion
}