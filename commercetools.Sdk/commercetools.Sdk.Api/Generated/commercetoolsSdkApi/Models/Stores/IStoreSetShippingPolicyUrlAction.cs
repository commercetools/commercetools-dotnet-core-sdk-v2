using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetShippingPolicyUrlAction))]
    public partial interface IStoreSetShippingPolicyUrlAction : IStoreUpdateAction
    {
        string ShippingPolicyUrl { get; set; }

    }
}
