using HondaDL;
using HondaBL;
using HondaModel;
using System;

public class Login
{
    static Collection motorCollection = new Collection();

    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("Enter Admin ID: ");
        string UserID = Console.ReadLine();

        Console.WriteLine("==============================");
        Console.Write("Enter Admin Password: ");
        string UserPass = Console.ReadLine();

        UserServices admin = new UserServices();
        bool result = admin.VerifyUser(UserID, UserPass);

        if (result)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Wrong user input!");
            Console.WriteLine("==============================");
            return;
        }

        while (true)
        {
            Login MotorLists = new Login();

            Console.WriteLine("==============================");
            Console.WriteLine("Options:");
            Console.WriteLine("1. View Collection Information");
            Console.WriteLine("2. View Cars");
            Console.WriteLine("3. Add Cars");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("==============================");
                    Console.WriteLine("Obscura Car Rental");
                    Console.WriteLine("\nWelcome to our ongoing little car rental collection, " +
                                      "where automotive excellence is displayed ");
                    break;

                case "2":
                    MotorModel Rac = new MotorModel();

                    Console.Write("Enter Car Model: ");
                    Rac.Model = Console.ReadLine();
                    Rac.yearModel = Convert.ToInt32(Console.ReadLine());
                    Rac.Displacement = Console.ReadLine();
                    Rac.Price = Convert.ToInt32(Console.ReadLine());
                    Rac.Stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("==============================");
               

                    break;

                case "3":
                    Console.WriteLine("==============================");
                    Console.WriteLine("Thank you for checking our collection. Goodbye!");
                    Console.WriteLine("==============================");
                    return;

                default:
                    Console.WriteLine("==============================");
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}