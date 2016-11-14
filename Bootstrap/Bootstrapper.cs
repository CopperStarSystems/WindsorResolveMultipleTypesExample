// WindsorResolveMultipleTypesExample
// Bootstrapper.cs
// 
// 2016-11-14
// =================================================================

using System.Linq;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.ModelBuilder;
using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using CopperStarSystems.WindsorHelpers;

namespace WindsorResolveMultipleTypesExample.Bootstrap
{
    internal static class Bootstrapper
    {
        // Just a standard bootstrapper, nothing special here.
        public static IWindsorContainer BootstrapContainer()
        {
            var container = new WindsorContainer().AddFacility<TypedFactoryFacility>();
            DisableDefaultPropertyInjection(container);
            EnableExplicitPropertyInjection(container);
            return container.Install(FromAssembly.This());
        }

        static void DisableDefaultPropertyInjection(IWindsorContainer container)
        {
            // By default, Windsor will inject default values for all public-settable, non-indexed properties.
            // We want to be more selective about which properties get injected values, so disable the default
            // injection behavior here.
            var propertyInjector =
                container.Kernel.ComponentModelBuilder.Contributors.OfType<PropertiesDependenciesModelInspector>()
                    .Single();
            container.Kernel.ComponentModelBuilder.RemoveContributor(propertyInjector);
        }

        static void EnableExplicitPropertyInjection(IWindsorContainer container)
        {
            // ExplicitPropertyDependenciesModelInspector will cause Windsor to only inject values for properties
            // that are decorated with InjectPropertyAttribute.
            container.Register(
                Component.For<IContributeComponentModelConstruction>()
                    .ImplementedBy<ExplicitPropertyDependenciesModelInspector>()
                    .LifeStyle.Singleton);
            var explicitPropertyDependenciesModelInspector = container.Resolve<IContributeComponentModelConstruction>();
            container.Kernel.ComponentModelBuilder.AddContributor(explicitPropertyDependenciesModelInspector);
        }
    }
}