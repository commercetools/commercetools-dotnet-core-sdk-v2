using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction))]
    public partial interface IProjectChangeProductSearchIndexingEnabledAction : IProjectUpdateAction
    {
        bool Enabled { get; set; }
    }
}
