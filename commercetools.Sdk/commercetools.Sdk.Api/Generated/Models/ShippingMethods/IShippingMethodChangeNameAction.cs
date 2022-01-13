using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    public partial interface IShippingMethodChangeNameAction : IShippingMethodUpdateAction
    {
        string Name { get; set; }
    }
}
