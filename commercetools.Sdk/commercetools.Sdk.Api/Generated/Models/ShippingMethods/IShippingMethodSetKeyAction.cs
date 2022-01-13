using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetKeyAction))]
    public partial interface IShippingMethodSetKeyAction : IShippingMethodUpdateAction
    {
        string Key { get; set; }
    }
}
