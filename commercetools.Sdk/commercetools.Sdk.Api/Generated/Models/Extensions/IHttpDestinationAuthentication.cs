using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Extensions.HttpDestinationAuthentication))]
    [SubTypeDiscriminator("AuthorizationHeader", typeof(commercetools.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    [SubTypeDiscriminator("AzureFunctions", typeof(commercetools.Api.Models.Extensions.AzureFunctionsAuthentication))]
    public partial interface IHttpDestinationAuthentication
    {
        string Type { get; set; }
    }
}
