using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddShippingAddressIdAction))]
    public partial interface IMyBusinessUnitAddShippingAddressIdAction : IMyBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
