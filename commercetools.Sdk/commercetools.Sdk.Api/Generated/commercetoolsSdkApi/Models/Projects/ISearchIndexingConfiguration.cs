using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.SearchIndexingConfiguration))]
    public partial interface ISearchIndexingConfiguration
    {
        ISearchIndexingConfigurationValues Products { get; set; }

        ISearchIndexingConfigurationValues ProductsSearch { get; set; }

        ISearchIndexingConfigurationValues Orders { get; set; }

        ISearchIndexingConfigurationValues Customers { get; set; }

    }
}
