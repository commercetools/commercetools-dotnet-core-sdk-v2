using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetBusinessUnitAction))]
    public partial interface ICartSetBusinessUnitAction : ICartUpdateAction
    {
        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

    }
}
