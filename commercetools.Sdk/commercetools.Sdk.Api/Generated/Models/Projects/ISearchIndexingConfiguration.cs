using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.SearchIndexingConfiguration))]
    public partial interface ISearchIndexingConfiguration
    {
        ISearchIndexingConfigurationValues Products { get; set; }
    }
}
