using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination))]
    public partial interface IAzureEventGridDestination : IDestination
    {
        string Uri { get; set; }

        string AccessKey { get; set; }

    }
}
