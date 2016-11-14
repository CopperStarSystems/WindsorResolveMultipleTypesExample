// WindsorResolveMultipleTypesExample
// RepeaterGreeter.cs
// 
// 2016-11-14
// =================================================================

using System;

namespace WindsorResolveMultipleTypesExample.Greeters
{
    public class RepeaterGreeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine("RepeaterGreeter:");
            for (int ctr = 0; ctr < 3; ctr++)
            {
                Console.WriteLine($"\tGreeting {ctr + 1} to {name}");
            }
        }
    }
}