using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload))]
    public partial interface IMessageDeliveryPayload : IDeliveryPayload
    {
        string Id { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

        long SequenceNumber { get; set; }

        long ResourceVersion { get; set; }

        IPayloadNotIncluded PayloadNotIncluded { get; set; }
    }
}
