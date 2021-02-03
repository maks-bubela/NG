using System;

namespace Pattern_Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.SetMoney(100, 5);

            atm.next = new ATM();
            atm.next.SetMoney(50, 10);

            atm.next.next = new ATM();
            atm.next.next.SetMoney(25, 10);

            atm.next.next.next = new ATM();
            atm.next.next.next.SetMoney(10, 10);

            atm.next.next.next.next = new ATM();
            atm.next.next.next.next.SetMoney(5, 30);

            atm.next.next.next.next.next = new ATM();
            atm.next.next.next.next.next.SetMoney(1, 50);

            Console.WriteLine("Enter summ you want : ");
            Console.WriteLine( atm.hundler(Convert.ToInt32(Console.ReadLine())));
            
        }
    }
}
