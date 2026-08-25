using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreImprintUrlSetMessage))]
    public partial interface IStoreImprintUrlSetMessage : IMessage
    {
        string ImprintUrl { get; set; }

    }
}
