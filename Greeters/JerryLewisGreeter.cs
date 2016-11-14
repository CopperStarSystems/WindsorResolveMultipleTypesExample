// WindsorResolveMultipleTypesExample
// JerryLewisGreeter.cs
// 
// 2016-11-14
// =================================================================

using System;

namespace WindsorResolveMultipleTypesExample.Greeters
{
    public class JerryLewisGreeter : IGreeter
    {
        public void Greet(string name)
        {
            Console.WriteLine($"*shrill voice* Hey {name}!!! *falls down*");
        }
    }
}