namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
           var Vidyaaccount = new BankAccount();
          Console.WriteLine("Enter the number which you like to deposit");
          var amountToDeposit = double.Parse(Console.ReadLine());
          Vidyaaccount.Deposit(amountToDeposit);
          Console.WriteLine($"Thank You! Check for your balance : {Vidyaaccount.GetBalance()}");
    }
}
}