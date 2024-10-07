using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SnsDestination))]
    public partial interface ISnsDestination : IDestination
    {
        string AccessKey { get; set; }

        string AccessSecret { get; set; }

        string TopicArn { get; set; }

        IAwsAuthenticationMode AuthenticationMode { get; set; }

    }
}
