using commercetools.Sdk.Api.Models.Projects;
using System;

namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{

    public partial class BusinessUnitSearchIndexingStatusResponse : IBusinessUnitSearchIndexingStatusResponse
    {
        public IBusinessUnitIndexingStatus Status { get; set; }

        public IBusinessUnitIndexingProgress States { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public int? RetryCount { get; set; }
    }
}
