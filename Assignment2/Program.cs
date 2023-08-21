using System;

class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountHolderName { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Details:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the BankAccount class
        BankAccount account = new BankAccount("123456789", "Sunil dagur", 1000.00);

        // Displaying initial account details
        account.DisplayAccountDetails();

        // Performing transactions
        account.Deposit(520.00);
        account.Withdraw(300.00);

        // Displaying updated account details
        account.DisplayAccountDetails();
    }
}
