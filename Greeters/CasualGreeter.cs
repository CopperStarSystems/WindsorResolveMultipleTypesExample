// WindsorResolveMultipleTypesExample
// CasualGreeter.cs
// 
// 2016-11-14
// =================================================================

using System;

namespace WindsorResolveMultipleTypesExample.Greeters
{
    // A greeter implementation that uses casual vernacular
    public class CasualGreeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hey, {name}, how's it going?");
        }
    }
}