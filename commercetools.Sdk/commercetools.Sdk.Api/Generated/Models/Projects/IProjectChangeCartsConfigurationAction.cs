using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction))]
    public partial interface IProjectChangeCartsConfigurationAction : IProjectUpdateAction
    {
        ICartsConfiguration CartsConfiguration { get; set; }

    }
}
