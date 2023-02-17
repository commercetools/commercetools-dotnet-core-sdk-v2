using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination))]
    public partial interface IGoogleCloudFunctionDestination : IExtensionDestination
    {
        string Url { get; set; }

    }
}
