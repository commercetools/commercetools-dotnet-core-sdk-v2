using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreRefundPolicyUrlSetMessage))]
    public partial interface IStoreRefundPolicyUrlSetMessage : IMessage
    {
        string RefundPolicyUrl { get; set; }

    }
}
