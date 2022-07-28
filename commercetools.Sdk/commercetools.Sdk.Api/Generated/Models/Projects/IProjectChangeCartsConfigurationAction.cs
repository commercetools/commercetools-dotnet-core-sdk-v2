using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction))]
    public partial interface IProjectChangeCartsConfigurationAction : IProjectUpdateAction
    {
        ICartsConfiguration CartsConfiguration { get; set; }

    }
}
