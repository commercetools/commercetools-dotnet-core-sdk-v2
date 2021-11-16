using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionAWSLambdaDestination))]
    public partial interface IExtensionAWSLambdaDestination : IExtensionDestination
    {
        string Arn { get; set; }

        string AccessKey { get; set; }

        string AccessSecret { get; set; }
    }
}
