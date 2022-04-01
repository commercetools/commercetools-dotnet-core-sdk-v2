using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    public partial interface IShippingMethodChangeNameAction : IShippingMethodUpdateAction
    {
        string Name { get; set; }
    }
}
