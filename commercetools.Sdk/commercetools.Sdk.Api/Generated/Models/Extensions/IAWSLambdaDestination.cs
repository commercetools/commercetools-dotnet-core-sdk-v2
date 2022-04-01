using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination))]
    public partial interface IAWSLambdaDestination : IExtensionDestination
    {
        string Arn { get; set; }

        string AccessKey { get; set; }

        string AccessSecret { get; set; }
    }
}
