// WindsorResolveMultipleTypesExample
// ReallyLoudGreeter.cs
// 
// 2016-11-14
// =================================================================

using System;

namespace WindsorResolveMultipleTypesExample.Greeters
{
    public class ReallyLoudGreeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"HELLO {name.ToUpper()}");
        }
    }
}