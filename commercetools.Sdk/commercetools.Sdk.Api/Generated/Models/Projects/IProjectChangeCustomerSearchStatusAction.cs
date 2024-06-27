using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCustomerSearchStatusAction))]
    public partial interface IProjectChangeCustomerSearchStatusAction : IProjectUpdateAction
    {
        ICustomerSearchStatus Status { get; set; }

    }
}
