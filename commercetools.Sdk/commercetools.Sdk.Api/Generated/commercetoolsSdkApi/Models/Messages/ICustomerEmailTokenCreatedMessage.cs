using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailTokenCreatedMessage))]
    public partial interface ICustomerEmailTokenCreatedMessage : IMessage
    {
        string CustomerId { get; set; }

        DateTime ExpiresAt { get; set; }

        string Value { get; set; }

        bool InvalidateOlderTokens { get; set; }

    }
}
