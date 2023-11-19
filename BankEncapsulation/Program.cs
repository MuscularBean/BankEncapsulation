using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much would you like to deposit?");
            
            var deposit = double.Parse(Console.ReadLine());
            
            BankAccount yourAccount = new BankAccount();

            yourAccount.Deposit(deposit);

            Console.WriteLine($"Thank you! Your balance is {yourAccount.GetBalance()}");

            

        }
    }
}
