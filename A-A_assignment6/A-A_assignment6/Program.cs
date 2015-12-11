using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_A_assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
     
                Account account = new Account();
                Console.Write("200 Deposited: " + account.deposit(200));
                Console.Write("100 withdrawed: " + account.withdraw(300));
                Console.ReadLine();
      
    }
}
