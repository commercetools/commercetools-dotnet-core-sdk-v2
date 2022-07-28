using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SqsDestination))]
    public partial interface ISqsDestination : IDestination
    {
        string AccessKey { get; set; }

        string AccessSecret { get; set; }

        string QueueUrl { get; set; }

        string Region { get; set; }

    }
}
