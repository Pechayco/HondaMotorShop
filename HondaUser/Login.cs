using HondaBL;
using HondaDL;
using HondaModel;
using System.Dynamic;

public class Login

{
    private static void ShowHistory(MotorModel motor)
    {


        Console.WriteLine("-----------------------");
        Console.WriteLine("Here's your Drink!");
        Console.WriteLine(motor.Model);
        Console.WriteLine(motor.yearModel);
        Console.WriteLine(motor.Displacement);
        Console.WriteLine(motor.Price);
        Console.WriteLine(motor.Stock);
        Console.WriteLine("-----------------------");

        {

            Collection motorCollection = new Collection();

            static void Main(string[] args)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Enter Admin ID: ");
                string UserID = Console.ReadLine();

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Enter Admin Password: ");
                string UserPass = Console.ReadLine();

                UserServices admin = new UserServices();
                bool result = admin.VerifyUser(UserID, UserPass);

                if (result)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Wrong admin info!!!!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    return;
                }

                while (true)
                {

                    static void Main(string[] args)
                    {

                        UserServices businessServices = new UserServices();
                        List<MotorModel> motorslist = businessServices.GetMotors();


                        Console.WriteLine("Please Choose an Option");
                        Console.WriteLine("1.Choose you Motorcycle");
                        Console.WriteLine("2.Exit");

                        int options = Convert.ToInt32(Console.ReadLine());

                        switch (options)

                        {
                            case 1:

                                Console.WriteLine("Welcome to Honda Motor Shop");
                                Console.WriteLine("\nMOTORCYCLES FOR SALE IN THE PHILIPPINES ");
                                Console.WriteLine("===============================");
                                Console.WriteLine("Choose your Motorcylcle");
                                Console.WriteLine("===============================");
                                Console.WriteLine("1. The New CLICK160");
                                Console.WriteLine("2. AirBlade160");
                                Console.WriteLine("3. The New PCX160");
                                Console.WriteLine("4. Honda CRF300 Rally");
                                Console.WriteLine("5. Honda Gold Wing 1800");
                                Console.WriteLine("===============================");

                                int motor = Convert.ToInt32(Console.ReadLine());
                                switch (motor)
                                {
                                    case 1:
                                        ShowHistory(motorslist[0]);
                                        break;
                                    case 2:
                                        ShowHistory(motorslist[1]);
                                        break;
                                    case 3:
                                        ShowHistory(motorslist[2]);
                                        break;
                                    case 4:
                                        ShowHistory(motorslist[3]);
                                        break;
                                    case 5:
                                        ShowHistory(motorslist[4]);
                                        break;
                                    case 6:
                                        ShowHistory(motorslist[5]);
                                        break;
                                    default:
                                        Console.WriteLine("UNIDENTIFIED NUMBER");
                                        break;
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}