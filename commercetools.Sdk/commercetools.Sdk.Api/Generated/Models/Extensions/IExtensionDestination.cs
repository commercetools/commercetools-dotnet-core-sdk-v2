using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Extensions.ExtensionDestination))]
    [SubTypeDiscriminator("AWSLambda", typeof(commercetools.Api.Models.Extensions.AWSLambdaDestination))]
    [SubTypeDiscriminator("HTTP", typeof(commercetools.Api.Models.Extensions.HttpDestination))]
    public partial interface IExtensionDestination
    {
        string Type { get; set; }
    }
}
