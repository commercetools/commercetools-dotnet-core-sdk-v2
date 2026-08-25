using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetRefundPolicyUrlAction))]
    public partial interface IStoreSetRefundPolicyUrlAction : IStoreUpdateAction
    {
        string RefundPolicyUrl { get; set; }

    }
}
