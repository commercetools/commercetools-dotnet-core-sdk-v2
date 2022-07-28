using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerToken))]
    public partial interface ICustomerToken
    {
        string Id { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime? LastModifiedAt { get; set; }

        string CustomerId { get; set; }

        DateTime ExpiresAt { get; set; }

        string Value { get; set; }

    }
}
