using System;
namespace sampleConApp
{
    class Ex04ClassAndObject
    {
        static void Main(String[] args)
        {
            MachineDatabase mac =new MachineDatabase();
            bool running = true;
            while(running)
            {
            Console.WriteLine("\n ********MENU********\n 1 : Register a new machine \n 2 : Update an existing machine \n 3 : Display all registered machines \n 4 : Delete Machine \n 5 : Exit \n \n Enter your choice : ");
            var choice =Console.ReadLine();

            switch (choice)
            {
                case "1": RegisterDevice(mac);
                            break;

                case "2":UpdateDevice(mac);
                            break;

                case "3":DisplayDevice(mac);
                            break;

                case "4":DeleteDevice(mac);
                            break;

                case "5": running = false;
                            break;

                default:Console.WriteLine("Invalid choice , plz try again with assosiated no. (1,2,3,4)");
                        break;
            }
            }    
        }

        static void RegisterDevice(MachineDatabase mac){
            Console.WriteLine("Enter Device Details: ");
            var slno=MyConsole.GetString("Enter slno");
            var make=MyConsole.GetString("Enter make");
            var model=MyConsole.GetString("Enter model");
            var price=MyConsole.GetInteger("Enter price");

            //to registerdevice
            Machine machine=new Machine{SlNo=slno,Make=make,Model=model,Price=price};
            mac.RegisterDevice(machine);
        }

        static void UpdateDevice(MachineDatabase mac){
            //to update registered device
            var slno=MyConsole.GetString("Enter slno of device to update :");
            var new_make=MyConsole.GetString("Enter new_make");
            var new_model=MyConsole.GetString("Enter new_model");
            var new_price=MyConsole.GetInteger("Enter new_price");
            mac.UpdateDeviceDetails(slno,new Machine{Make=new_make,Model=new_model,Price=new_price});
        }

        static void DisplayDevice(MachineDatabase mac){
            //to display all devices
            var list = mac.GetAllRegisteredDevices();
            foreach(var machines in list){
                Console.WriteLine(machines);
            }
        }

        static void DeleteDevice(MachineDatabase mac){
            var slno=MyConsole.GetString("Enter the slno to Delete the Machine :");
            mac.DeleteMachine(slno);
        }
    }
}