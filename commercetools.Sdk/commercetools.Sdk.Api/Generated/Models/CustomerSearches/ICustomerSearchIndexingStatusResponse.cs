using commercetools.Sdk.Api.Models.Projects;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerSearchIndexingStatusResponse))]
    public partial interface ICustomerSearchIndexingStatusResponse
    {
        ICustomerIndexingStatus Status { get; set; }

        ICustomerIndexingProgress States { get; set; }

        DateTime? StartedAt { get; set; }

        DateTime? LastModifiedAt { get; set; }

        int? RetryCount { get; set; }

    }
}
