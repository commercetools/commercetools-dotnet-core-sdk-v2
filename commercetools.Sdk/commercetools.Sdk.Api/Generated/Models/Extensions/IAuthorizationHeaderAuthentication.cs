using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    public partial interface IAuthorizationHeaderAuthentication : IHttpDestinationAuthentication
    {
        string HeaderValue { get; set; }
    }
}
