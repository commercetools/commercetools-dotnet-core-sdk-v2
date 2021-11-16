using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeNameAction))]
    public partial interface IProjectChangeNameAction : IProjectUpdateAction
    {
        string Name { get; set; }
    }
}
