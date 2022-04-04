using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference))]
    public partial interface IShippingMethodReference : IReference
    {
        IShippingMethod Obj { get; set; }
    }
}
