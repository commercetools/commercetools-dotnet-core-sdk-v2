using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreOrderUrlTemplateSetMessage))]
    public partial interface IStoreOrderUrlTemplateSetMessage : IMessage
    {
        string OrderUrlTemplate { get; set; }

    }
}
