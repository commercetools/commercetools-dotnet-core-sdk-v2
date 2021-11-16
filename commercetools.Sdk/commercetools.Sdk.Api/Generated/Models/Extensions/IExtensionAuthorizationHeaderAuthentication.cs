using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionAuthorizationHeaderAuthentication))]
    public partial interface IExtensionAuthorizationHeaderAuthentication : IExtensionHttpDestinationAuthentication
    {
        string HeaderValue { get; set; }
    }
}
