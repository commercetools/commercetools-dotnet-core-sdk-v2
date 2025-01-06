

namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class SearchIndexingConfiguration : ISearchIndexingConfiguration
    {
        public ISearchIndexingConfigurationValues Products { get; set; }

        public ISearchIndexingConfigurationValues ProductsSearch { get; set; }

        public ISearchIndexingConfigurationValues Orders { get; set; }

        public ISearchIndexingConfigurationValues Customers { get; set; }

        public ISearchIndexingConfigurationValues BusinessUnits { get; set; }
    }
}
