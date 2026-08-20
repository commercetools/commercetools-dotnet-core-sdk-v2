using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCookiePolicyUrlSetMessagePayload))]
    public partial interface IStoreCookiePolicyUrlSetMessagePayload : IMessagePayload
    {
        string CookiePolicyUrl { get; set; }

    }
}
