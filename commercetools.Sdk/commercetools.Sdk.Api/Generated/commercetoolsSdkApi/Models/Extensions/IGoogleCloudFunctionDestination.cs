using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination))]
    public partial interface IGoogleCloudFunctionDestination : IExtensionDestination
    {
        string Url { get; set; }

    }
}
