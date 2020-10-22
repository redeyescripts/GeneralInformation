using System;

namespace GeneralInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter youre ID code ");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                
                HelloUser(usersID);
                GetYear(usersID);
                Num();
            }
            else
            {
                Console.WriteLine("Wrong format. Try again.");
            }

            Console.ReadLine();
        }
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
                Console.ReadLine();
            }
            else
            {
                return false;
            }

        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello, Sir");
            }
            else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }

        public static int GetYear(string idCode)
        {

            string yearFromCode = idCode.Substring(1, 2);
            string year;

            if (int.Parse(idCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;
            }

            Console.WriteLine($"You were born in {year}");
            int yearParsed = Int32.Parse(year);

            return yearParsed;
        }

        public static void GetAge(string idCode)
        {
            int yearOfBirth = GetYear(idCode);


          
           

            
        }

        public static bool Num()
           
        {
            Console.WriteLine("Enter your CVV");
            string cvv = Console.ReadLine();     
            
            if (cvv.Length == 3)
            {
                try 
                {
                    Int32.Parse(cvv);
                    Console.WriteLine("All good");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format {e}");
                    return false;
                }
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Wrong code!");
                return false;
            }
            Console.ReadLine();

        }
    }      

    
}        

