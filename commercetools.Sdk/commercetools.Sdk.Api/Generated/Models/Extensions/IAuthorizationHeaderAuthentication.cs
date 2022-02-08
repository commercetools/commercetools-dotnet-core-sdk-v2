using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    public partial interface IAuthorizationHeaderAuthentication : IHttpDestinationAuthentication
    {
        string HeaderValue { get; set; }
    }
}
