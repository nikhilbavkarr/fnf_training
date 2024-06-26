using System;
namespace sampleConApp
{
    enum AccountType{
        SBAccount=1,

        RDAccount,

        FDAccount
    }
    class Ex03Enums
    {
        static void Main(string[] args)
        {
            enumInputExample();
            //Console.WriteLine("The Account selected id " +acc);

        }

        static void enumInputExample()
        {
            Array array=Enum.GetValues(typeof(AccountType));
            Console.WriteLine("Enter the type of account listed below");
            foreach(object value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            AccountType acc=(AccountType)Enum.Parse(typeof(AccountType),Console.ReadLine(), true);
            Console.WriteLine("The Account selected id " +acc);

            
           /* Console.WriteLine("Select account type : \n 1 for SBAccount \n 2 for RDAccount \n 3 for FDAccount");
            int n=int.Parse(Console.ReadLine());

            AccountType acc=(n)acc;
            Console.WriteLine("The Account selected id " +acc);

            //AccountType acc=(AccountType)n;
            //Console.WriteLine("The Account selected id " +acc);

            /*if(Enum.IsDefined(typeof(AccountType),n)){
                AccountType acc=(AccountType)n;
                Console.WriteLine("The Account selected id " +acc);
            }*/
        }
    }
}