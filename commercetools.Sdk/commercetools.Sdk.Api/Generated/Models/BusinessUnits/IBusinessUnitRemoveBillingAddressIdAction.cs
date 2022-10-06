using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveBillingAddressIdAction))]
    public partial interface IBusinessUnitRemoveBillingAddressIdAction : IBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
