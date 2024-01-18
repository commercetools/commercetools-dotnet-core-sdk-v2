using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchStatusAction))]
    public partial interface IProjectChangeProductSearchStatusAction : IProjectUpdateAction
    {
        IProductSearchStatus Status { get; set; }

    }
}
