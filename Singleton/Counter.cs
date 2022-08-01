using System;

namespace Singleton
{
    public  class Counter_singleton
    {
       public    int Count = 0;
        public static Counter_singleton instance = null;
        public string Value { get; set; }


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
        public int Decrement(int value)
        {

            Count-=value;
            return Count;
           
        }
        public int Increment(int value)
        {
           Count+=value;
            return Count;
        }

        public string  ToCurrency(int value)
        {
            return string.Concat('$',value);
        }


    }
}
