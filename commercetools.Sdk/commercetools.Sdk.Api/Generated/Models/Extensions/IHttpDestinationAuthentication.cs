using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.HttpDestinationAuthentication))]
    [SubTypeDiscriminator("AuthorizationHeader", typeof(commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    [SubTypeDiscriminator("AzureFunctions", typeof(commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication))]
    public partial interface IHttpDestinationAuthentication
    {
        string Type { get; set; }
    }
}
