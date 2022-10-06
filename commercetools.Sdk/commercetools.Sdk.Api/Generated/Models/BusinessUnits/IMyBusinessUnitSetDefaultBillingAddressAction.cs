using commercetools.Sdk.Api.Models.Me;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.MyBusinessUnitSetDefaultBillingAddressAction))]
    public partial interface IMyBusinessUnitSetDefaultBillingAddressAction : IMyBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
