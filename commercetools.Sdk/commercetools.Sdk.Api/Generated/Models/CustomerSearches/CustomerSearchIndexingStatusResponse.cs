using commercetools.Sdk.Api.Models.CustomerSearches;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomerSearches
{

    public partial class CustomerSearchIndexingStatusResponse : ICustomerSearchIndexingStatusResponse
    {
        public ICustomerIndexingStatus Status { get; set; }

        public ICustomerIndexingProgress States { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public int? RetryCount { get; set; }
    }
}
