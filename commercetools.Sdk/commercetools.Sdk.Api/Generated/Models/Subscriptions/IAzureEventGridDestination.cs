using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination))]
    [System.Obsolete]
    public partial interface IAzureEventGridDestination : IDestination
    {
        string Uri { get; set; }

        string AccessKey { get; set; }

    }
}
