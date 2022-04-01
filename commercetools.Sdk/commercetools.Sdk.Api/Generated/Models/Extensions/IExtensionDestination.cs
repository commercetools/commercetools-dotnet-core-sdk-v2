using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionDestination))]
    [SubTypeDiscriminator("AWSLambda", typeof(commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination))]
    [SubTypeDiscriminator("HTTP", typeof(commercetools.Sdk.Api.Models.Extensions.HttpDestination))]
    public partial interface IExtensionDestination
    {
        string Type { get; set; }
    }
}
