using System;
using ExtensionMethods;

namespace Singleton
{
    public  class Counter_singleton
    {
       public    int Count = 0;
        public static Counter_singleton instance = null;
  


        private Counter_singleton()
        {
            Console.WriteLine("current intial value " + Count);
        }

        
        public static Counter_singleton ObjectCreate
        {
            get
            {
                if (instance == null)
                {
                    instance =  new Counter_singleton();
                }
                return instance;
            }
        }
        public string Decrement(int value)
        {

            Count-=value;
            return Count.checkvalue();
           
        }
        public string Increment(int value)
        {
           Count+=value;
            return Count.checkvalue();
        }

     

    }
}
