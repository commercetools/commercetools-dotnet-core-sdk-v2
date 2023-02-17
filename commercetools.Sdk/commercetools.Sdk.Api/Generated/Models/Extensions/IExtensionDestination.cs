using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionDestination))]
    [SubTypeDiscriminator("AWSLambda", typeof(commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination))]
    [SubTypeDiscriminator("GoogleCloudFunction", typeof(commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination))]
    [SubTypeDiscriminator("HTTP", typeof(commercetools.Sdk.Api.Models.Extensions.HttpDestination))]
    public partial interface IExtensionDestination
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination AwsLambda(Action<commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.AWSLambdaDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination GoogleCloudFunction(Action<commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.GoogleCloudFunctionDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.HttpDestination Http(Action<commercetools.Sdk.Api.Models.Extensions.HttpDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.HttpDestination();
            init?.Invoke(t);
            return t;
        }
    }
}
