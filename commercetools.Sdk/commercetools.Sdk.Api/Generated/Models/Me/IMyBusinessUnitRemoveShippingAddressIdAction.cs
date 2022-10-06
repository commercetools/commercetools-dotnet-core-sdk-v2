using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitRemoveShippingAddressIdAction))]
    public partial interface IMyBusinessUnitRemoveShippingAddressIdAction : IMyBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
