// WindsorResolveMultipleTypesExample
// IGreetersFactory.cs
// 
// 2016-11-14
// =================================================================

using CopperStarSystems.WindsorHelpers.CustomAttributes;
using WindsorResolveMultipleTypesExample.Greeters;

namespace WindsorResolveMultipleTypesExample.Factories
{
    [WindsorFactory]
    public interface IGreetersFactory
    {
        // Because this method returns an IEnumerable, it basically tells Windsor:
        // "Hey, give me one instance of each type that implements this interface."
        //
        // This is per the TypedFactoryFacility documentation at:
        // https://github.com/castleproject/Windsor/blob/master/docs/typed-factory-facility-interface-based.md
        // https://github.com/castleproject/Windsor/blob/master/docs/typed-factory-facility-interface-based.md#collection-methods-resolve-multiple-components
        // The method below satisfies the IEnumerable<T> requirement (arrays are enumerable), so will return an array of
        // concrete instances implementing IGreeter, automatically resolved by Windsor.
        IGreeter[] Create();
    }
}