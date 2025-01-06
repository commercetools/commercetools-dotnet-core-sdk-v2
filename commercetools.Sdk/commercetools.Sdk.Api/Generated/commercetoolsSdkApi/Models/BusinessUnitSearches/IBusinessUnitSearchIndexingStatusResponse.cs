using commercetools.Sdk.Api.Models.Projects;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnitSearches.BusinessUnitSearchIndexingStatusResponse))]
    public partial interface IBusinessUnitSearchIndexingStatusResponse
    {
        IBusinessUnitIndexingStatus Status { get; set; }

        IBusinessUnitIndexingProgress States { get; set; }

        DateTime? StartedAt { get; set; }

        DateTime? LastModifiedAt { get; set; }

        int? RetryCount { get; set; }

    }
}
