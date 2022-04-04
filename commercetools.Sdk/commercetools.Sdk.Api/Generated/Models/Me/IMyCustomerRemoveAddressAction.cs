using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerRemoveAddressAction))]
    public partial interface IMyCustomerRemoveAddressAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }
    }
}
