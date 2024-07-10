using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class SearchIndexingConfigurationValues : ISearchIndexingConfigurationValues
    {
        public ISearchIndexingConfigurationStatus Status { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }
    }
}
