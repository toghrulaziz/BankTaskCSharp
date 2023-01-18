using BankTaskCSharp;

BankCard bc1 = new("Kapital Bank","Kapital Bank","0000000000000000","1234","06/23",1234);
BankCard bc2 = new("Kapital Bank","Kapital Bank","1111111111111111","2345","07/23",4567);
BankCard bc3 = new("Kapital Bank","Kapital Bank","2222222222222222","3456","08/23",74833);
BankCard bc4 = new("Kapital Bank","Kapital Bank","3333333333333333","3456","09/23",34353);
BankCard bc5 = new("Kapital Bank","Kapital Bank","4444444444444444","4567","10/23",75674);

User u1 = new("Togrul", "Azizli", bc1);
User u2 = new("Elon", "Musk", bc2);
User u3 = new("Bill", "Gates", bc3);
User u4 = new("Jeff", "Bezos", bc4);
User u5 = new("John", "Doe", bc5);


List<User> users = new();

users.Add(u1);
users.Add(u2);
users.Add(u3);
users.Add(u4);
users.Add(u5);

Console.WriteLine("Insert PIN: ");
string? pin;
pin = Console.ReadLine();

foreach (var user in users)
{
    if(pin == user.BankCard.PIN)
    {
        Console.Clear();
        Console.WriteLine($"{user.Name} {user.Surname} Xosh Gelmisiniz!");
        Console.WriteLine("\n1.Balance \n2.Cash \n3.Card to card \n4.Exit\n");

        Console.WriteLine("Insert choose: ");
        string? choose;
        choose = Console.ReadLine();

        if(choose == "1")
        {
            Console.Clear();
            Console.WriteLine($"Balance: {user.BankCard.Balance}\n");
        }

        else if(choose == "2")
        {
            Console.Clear();
            Console.WriteLine("1.10 azn \n2.20 azn \n3.50 azn \n4.100 azn \n5.Insert quantity\n");
            int cho;
            cho = Convert.ToInt32(Console.ReadLine());

            switch (cho)
            {
                case 1:
                    try
                    {
                        user.BankCard.DecreaseBalance(10);
                        Console.Clear();
                        Console.WriteLine("10 AZN converted to cash");
                        Console.WriteLine($"Balance: {user.BankCard.Balance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;


                case 2:
                    try
                    {
                        user.BankCard.DecreaseBalance(20);
                        Console.Clear();
                        Console.WriteLine("20 AZN converted to cash");
                        Console.WriteLine($"Balance: {user.BankCard.Balance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;


                case 3:
                    try
                    {
                        user.BankCard.DecreaseBalance(50);
                        Console.Clear();
                        Console.WriteLine("50 AZN converted to cash");
                        Console.WriteLine($"Balance: {user.BankCard.Balance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;

                case 4:
                    try
                    {
                        user.BankCard.DecreaseBalance(100);
                        Console.Clear();
                        Console.WriteLine("100 AZN converted to cash");
                        Console.WriteLine($"Balance: {user.BankCard.Balance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;

                case 5:
                    Console.Clear();
                    decimal money;
                    Console.WriteLine("Insert Amount: ");
                    money = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        user.BankCard.DecreaseBalance(money);
                        Console.Clear();
                        Console.WriteLine($"{money} AZN converted to cash");
                        Console.WriteLine($"Balance: {user.BankCard.Balance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;
            }
        }

        else if(choose == "3")
        {
            Console.Clear();
            string? pan;
            Console.WriteLine("Insert PAN: ");
            pan = Console.ReadLine();

            bool truefalse = false;
            Console.Clear();

            foreach (User u in users)
            {
                if (u.BankCard.PAN == pan)
                {
                    truefalse = true;
                    decimal amount;
                    Console.WriteLine($"Your Balance: {user.BankCard.Balance}");
                    Console.WriteLine("Insert Amount: ");
                    amount = Convert.ToDecimal(Console.ReadLine());

                    try
                    {
                        u.BankCard.DecreaseBalance(amount);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Clear(); 
                    }

                    u.BankCard.IncreaseBalance(amount);
                }
            }
            if (!truefalse)
            {
                Console.WriteLine("Card couldn't found!");
            }
        }

        else if(choose == "4")
        {
            break;
        }
    }
}



