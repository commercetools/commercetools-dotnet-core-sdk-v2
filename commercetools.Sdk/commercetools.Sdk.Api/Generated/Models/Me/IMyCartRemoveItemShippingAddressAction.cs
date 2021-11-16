using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartRemoveItemShippingAddressAction))]
    public partial interface IMyCartRemoveItemShippingAddressAction : IMyCartUpdateAction
    {
        string AddressKey { get; set; }
    }
}
