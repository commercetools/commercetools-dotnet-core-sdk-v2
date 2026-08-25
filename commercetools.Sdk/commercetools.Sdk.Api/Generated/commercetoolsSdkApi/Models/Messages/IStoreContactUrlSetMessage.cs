using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreContactUrlSetMessage))]
    public partial interface IStoreContactUrlSetMessage : IMessage
    {
        string ContactUrl { get; set; }

    }
}
