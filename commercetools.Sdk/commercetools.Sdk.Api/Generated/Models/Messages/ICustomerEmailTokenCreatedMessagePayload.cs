using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessagePayload))]
    public partial interface ICustomerEmailTokenCreatedMessagePayload : IMessagePayload
    {
        string CustomerId { get; set; }

        DateTime ExpiresAt { get; set; }

    }
}
