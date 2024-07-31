using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication))]
    public partial interface IAzureFunctionsAuthentication : IHttpDestinationAuthentication
    {
        string Key { get; set; }

    }
}
