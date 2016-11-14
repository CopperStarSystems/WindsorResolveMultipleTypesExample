// WindsorResolveMultipleTypesExample
// IGreeter.cs
// 
// 2016-11-14
// =================================================================

namespace WindsorResolveMultipleTypesExample.Greeters
{
    // The IGreeter interface specifies a common API for Greeter
    // classes, allowing us to resolve all implementing types via
    // the Windsor TypedFactoryFacility.
    public interface IGreeter
    {
        void Greet(string name);
    }
}