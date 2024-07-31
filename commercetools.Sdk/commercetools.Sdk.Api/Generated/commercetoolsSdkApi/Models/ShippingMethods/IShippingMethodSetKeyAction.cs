using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction))]
    public partial interface IShippingMethodSetKeyAction : IShippingMethodUpdateAction
    {
        string Key { get; set; }

    }
}
