// WindsorResolveMultipleTypesExample
// WindsorResolveMultipleTypesExampleInstaller.cs
// 
// 2016-11-14
// =================================================================

using CopperStarSystems.WindsorHelpers;

namespace WindsorResolveMultipleTypesExample.Bootstrap
{
    public class WindsorResolveMultipleTypesExampleInstaller : AssemblyInstallerBase
    {
        public WindsorResolveMultipleTypesExampleInstaller() : base("WindsorResolveMultipleTypesExample")
        {
            // Note that we do not have to do any manual registration to wire up the
            // IGreeter interface to implementations.  We also don't need an abstract base
            // class, the interface is what ties things together.
        }
    }
}