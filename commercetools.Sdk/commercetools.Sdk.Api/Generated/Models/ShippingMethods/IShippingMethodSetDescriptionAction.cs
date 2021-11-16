using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction))]
    public partial interface IShippingMethodSetDescriptionAction : IShippingMethodUpdateAction
    {
        string Description { get; set; }
    }
}
