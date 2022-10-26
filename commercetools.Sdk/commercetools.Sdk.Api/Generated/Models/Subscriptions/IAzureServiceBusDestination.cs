using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination))]
    [System.Obsolete]
    public partial interface IAzureServiceBusDestination : IDestination
    {
        string ConnectionString { get; set; }

    }
}
