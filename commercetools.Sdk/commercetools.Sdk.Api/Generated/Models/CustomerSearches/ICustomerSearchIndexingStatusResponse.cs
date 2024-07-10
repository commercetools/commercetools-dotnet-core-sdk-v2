using commercetools.Sdk.Api.Models.CustomerSearches;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
