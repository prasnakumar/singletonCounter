using Singleton;
using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = true;

            Counter_singleton counter = Counter_singleton.ObjectCreate;//Creates 1 only one instance 
            
           
            Counter_singleton counter1 = Counter_singleton.ObjectCreate;//Creates  2 but only one instance 

          



            while (options)
            {
                Console.WriteLine("please select the following action \n1: Increment  \n2: Decrement  \n3: Display Number \n0: Exit ");
                var select = Console.ReadLine();
                //this can be changes to switch 
                if ( select == "1")
                {
                    Console.WriteLine("Enter the value ");
                    var  Valuecheck= Console.ReadLine();
                    try
                    {
                       int  Value = int.Parse(Valuecheck);
                        int valuecounter = counter.Increment(Value);
                        Console.WriteLine(counter.ToCurrency(valuecounter));
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                   
                }
                else if (select == "2")
                {
                    Console.WriteLine("Enter the value ");
                    var Valuecheck = Console.ReadLine();
                    try
                    {
                        int Value = int.Parse(Valuecheck);
                       int valuecounter= counter.Decrement(Value);
                        Console.WriteLine(counter.ToCurrency(valuecounter));
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else if (select == "3")
                {
                  Console.WriteLine("current counter $"+Counter_singleton.instance.Count);
                }
                else if (select == "0")
                {
                    Console.WriteLine("Bye.... ");
                    options = false;
                }
                else
                {
                    Console.WriteLine("Invalid Option....");
                   
                }
            }
            
            

           
        }
    }

    
}
