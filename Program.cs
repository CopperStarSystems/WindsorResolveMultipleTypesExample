// WindsorResolveMultipleTypesExample
// Program.cs
// 
// 2016-11-14
// =================================================================

using System;
using WindsorResolveMultipleTypesExample.Bootstrap;

namespace WindsorResolveMultipleTypesExample
{
    class Program
    {
        // Main() is our entry point, so that's where we'll get things set 
        // up and kicked off.
        static void Main(string[] args)
        {
            var compositionRoot = ResolveCompositionRoot();
            var name = GetNameFromArgs(args);
            
            // compositionRoot is of type IGreeterConsumer
            compositionRoot.RunAllGreetings(name);
            Console.ReadKey();
        }

        static IGreeterConsumer ResolveCompositionRoot()
        {
            var container = Bootstrapper.BootstrapContainer();
            var compositionRoot = container.Resolve<IGreeterConsumer>();
            return compositionRoot;
        }

        static string GetNameFromArgs(string[] args)
        {
            if (args.Length <= 1)
                return "Default Name";
            return args[1];
        }
    }
}