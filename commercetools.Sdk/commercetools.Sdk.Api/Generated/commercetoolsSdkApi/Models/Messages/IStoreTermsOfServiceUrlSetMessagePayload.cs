using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreTermsOfServiceUrlSetMessagePayload))]
    public partial interface IStoreTermsOfServiceUrlSetMessagePayload : IMessagePayload
    {
        string TermsOfServiceUrl { get; set; }

    }
}
