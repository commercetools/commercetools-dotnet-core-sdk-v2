using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    public partial interface IGoogleCloudPubSubDestination : IDestination
    {
        string ProjectId { get; set;}
        
        string Topic { get; set;}
    }
}
