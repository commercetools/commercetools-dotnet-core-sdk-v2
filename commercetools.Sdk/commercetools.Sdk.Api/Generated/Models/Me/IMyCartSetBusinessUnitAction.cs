using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetBusinessUnitAction))]
    public partial interface IMyCartSetBusinessUnitAction : IMyCartUpdateAction
    {
        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

    }
}
