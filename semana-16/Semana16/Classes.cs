using Classes;

var account = new BankAccount("<Sophia>", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Test that the initial balances must be positive:
try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}

// Test for a negative balance
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}

try
{
    account.MakeDeposit(300, DateTime.Now, null); // Prueba para insertar un valor nulo al string
}
catch (ArgumentNullException e)
{
    Console.WriteLine("The user must write a note");
    Console.WriteLine(e.ToString());
}

try
{
    account.MakeWithdrawal(300, DateTime.Now, null);
}
catch (ArgumentNullException e)
{
    Console.WriteLine("The user must write a note");
    Console.WriteLine(e.ToString());
}
try
{
    account.MakeDeposit(0, DateTime.Now, "nota"); // Prueba para depositar 0
}
catch (ArgumentException e)
{
    Console.WriteLine("The amount should be greater than 0");
    Console.WriteLine(e.ToString());
}
try
{
    account.MakeWithdrawal(0, DateTime.Now, "nota"); // Prueba para depositar 0
}
catch (ArgumentException e)
{
    Console.WriteLine("The amount should be greater than 0");
    Console.WriteLine(e.ToString());
}