using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.SearchIndexingConfiguration))]
    public partial interface ISearchIndexingConfiguration
    {
        ISearchIndexingConfigurationValues Products { get; set; }

        ISearchIndexingConfigurationValues Orders { get; set; }
    }
}
