using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCarrierAction))]
    public partial interface IShippingMethodSetCarrierAction : IShippingMethodUpdateAction
    {
        string Carrier { get; set; }

    }
}
