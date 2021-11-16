using commercetools.Api.Models.Common;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class SearchIndexingConfigurationValues : ISearchIndexingConfigurationValues
    {
        public ISearchIndexingConfigurationStatus Status { get; set;}
        
        public DateTime? LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
    }
}
