using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SnsDestination))]
    public partial interface ISnsDestination : IDestination
    {
        string AccessKey { get; set;}
        
        string AccessSecret { get; set;}
        
        string TopicArn { get; set;}
    }
}
