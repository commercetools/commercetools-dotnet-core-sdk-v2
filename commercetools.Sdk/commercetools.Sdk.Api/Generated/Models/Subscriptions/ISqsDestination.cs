using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SqsDestination))]
    public partial interface ISqsDestination : IDestination
    {
        string AccessKey { get; set; }

        string AccessSecret { get; set; }

        string QueueUrl { get; set; }

        string Region { get; set; }

        IAwsAuthenticationMode AuthenticationMode { get; set; }

    }
}
