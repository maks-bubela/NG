using System;

namespace Pattern_Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Valuta atm = new Valuta(100, 5);
            atm.next = new Valuta(50, 10);
            atm.next.next = new Valuta(25, 10);
            atm.next.next.next = new Valuta(10, 10);
            atm.next.next.next.next = new Valuta(5, 30);
            atm.next.next.next.next.next = new Valuta(1, 50);

            Console.WriteLine("Enter summ you want : ");
            Console.WriteLine( atm.hundler(Convert.ToInt32(Console.ReadLine())));
            
        }
    }
}
