using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction))]
    public partial interface IProjectChangeNameAction : IProjectUpdateAction
    {
        string Name { get; set; }

    }
}
