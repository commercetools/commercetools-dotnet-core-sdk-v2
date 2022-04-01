using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction))]
    public partial interface IShippingMethodSetDescriptionAction : IShippingMethodUpdateAction
    {
        string Description { get; set; }
    }
}
