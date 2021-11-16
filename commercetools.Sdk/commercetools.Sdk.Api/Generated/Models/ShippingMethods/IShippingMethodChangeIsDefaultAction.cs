using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction))]
    public partial interface IShippingMethodChangeIsDefaultAction : IShippingMethodUpdateAction
    {
        bool IsDefault { get; set; }
    }
}
