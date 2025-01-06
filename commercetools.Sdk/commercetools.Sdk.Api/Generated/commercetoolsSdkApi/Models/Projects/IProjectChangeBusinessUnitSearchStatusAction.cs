using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitSearchStatusAction))]
    public partial interface IProjectChangeBusinessUnitSearchStatusAction : IProjectUpdateAction
    {
        IBusinessUnitSearchStatus Status { get; set; }

    }
}
