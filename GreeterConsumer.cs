// WindsorResolveMultipleTypesExample
// GreeterConsumer.cs
// 
// 2016-11-14
// =================================================================

using WindsorResolveMultipleTypesExample.Factories;

namespace WindsorResolveMultipleTypesExample
{
    // This class has a dependency on all types implementing IGreeter
    // so that it can perform an operation on each.  
    public class GreeterConsumer : IGreeterConsumer
    {
        readonly IGreetersFactory greetersFactory;

        // Windsor does not resolve type arrays (i.e. IGreeter[]) by default.
        // There is a way to enable this behavior, but it disables some other
        // valuable Windsor features such as circular dependency detection.
        //
        // Because of this, we use the TypedFactoryFacility, taking a dependency
        // on an IGreetersFactory, which knows how to identify, resolve, and return
        // all IGreeter types.
        public GreeterConsumer(IGreetersFactory greetersFactory)
        {
            // We'll just store the factory for the moment,
            // we'll create our Greeters right before we need them.
            this.greetersFactory = greetersFactory;
        }

        // Creates and executes all IGreeters once.
        public void RunAllGreetings(string name)
        {
            // Create the greeters from the factory
            var greeters = greetersFactory.Create();

            // Loop over the greeters, invoking the
            // Greet method on each.
            foreach (var greeter in greeters)
                greeter.Greet(name);
        }
    }
}