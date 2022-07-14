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
        public void Decrement()
        {
            
            Console.WriteLine("Action Decrement Count is " + --Count);
           
        }
        public void Increment()
        {
            
            Console.WriteLine("Action Increment Count  is  " + ++Count);
           
        }
        
        
    }
}
