using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ExternalOAuth))]
    public partial interface IExternalOAuth
    {
        string Url { get; set; }

        string AuthorizationHeader { get; set; }

    }
}
