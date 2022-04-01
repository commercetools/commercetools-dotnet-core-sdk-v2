using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction))]
    public partial interface IShippingMethodSetKeyAction : IShippingMethodUpdateAction
    {
        string Key { get; set; }
    }
}
