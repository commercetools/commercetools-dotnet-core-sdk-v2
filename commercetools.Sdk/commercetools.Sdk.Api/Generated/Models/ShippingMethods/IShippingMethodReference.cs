using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodReference))]
    public partial interface IShippingMethodReference : IReference
    {
        IShippingMethod Obj { get; set; }
    }
}
