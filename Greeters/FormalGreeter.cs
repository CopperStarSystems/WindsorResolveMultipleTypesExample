// WindsorResolveMultipleTypesExample
// FormalGreeter.cs
// 
// 2016-11-14
// =================================================================

using System;

namespace WindsorResolveMultipleTypesExample.Greeters
{
    // A greeter implementation that uses awkwardly formal vernacular
    public class FormalGreeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Welcome, honorable {name}");
        }
    }
}