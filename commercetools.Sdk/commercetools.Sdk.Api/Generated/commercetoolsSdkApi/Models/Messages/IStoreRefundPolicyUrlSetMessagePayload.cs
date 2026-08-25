using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreRefundPolicyUrlSetMessagePayload))]
    public partial interface IStoreRefundPolicyUrlSetMessagePayload : IMessagePayload
    {
        string RefundPolicyUrl { get; set; }

    }
}
