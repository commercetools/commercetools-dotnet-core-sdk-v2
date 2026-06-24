using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddStoreAction))]
    public partial interface IShippingMethodAddStoreAction : IShippingMethodUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
