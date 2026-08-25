using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCookiePolicyUrlSetMessage))]
    public partial interface IStoreCookiePolicyUrlSetMessage : IMessage
    {
        string CookiePolicyUrl { get; set; }

    }
}
