using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    public partial interface IGoogleCloudPubSubDestination : IDestination
    {
        string ProjectId { get; set; }

        string Topic { get; set; }

    }
}
