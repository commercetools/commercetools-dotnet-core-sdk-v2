using System;


namespace commercetools.Api.Models.Projects
{
    public partial class SearchIndexingConfigurationValues : ISearchIndexingConfigurationValues
    {
        public ISearchIndexingConfigurationStatus Status { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
