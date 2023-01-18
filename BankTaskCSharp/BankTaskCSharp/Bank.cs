using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTaskCSharp
{
    internal class Bank
    {
        public static Client[] clients;

        public static void showCardBalance(BankCard card) { Console.WriteLine(card.Balance); }


    }
}
