using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeActiveAction))]
    public partial interface IShippingMethodChangeActiveAction : IShippingMethodUpdateAction
    {
        bool Active { get; set; }

    }
}
