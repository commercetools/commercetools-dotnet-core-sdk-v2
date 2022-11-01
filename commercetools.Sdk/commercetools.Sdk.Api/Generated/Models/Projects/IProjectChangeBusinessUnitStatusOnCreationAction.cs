using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitStatusOnCreationAction))]
    public partial interface IProjectChangeBusinessUnitStatusOnCreationAction : IProjectUpdateAction
    {
        IBusinessUnitConfigurationStatus Status { get; set; }

    }
}
