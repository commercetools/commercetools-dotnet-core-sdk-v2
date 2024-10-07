using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    public partial interface IAuthorizationHeaderAuthentication : IHttpDestinationAuthentication
    {
        string HeaderValue { get; set; }

    }
}
