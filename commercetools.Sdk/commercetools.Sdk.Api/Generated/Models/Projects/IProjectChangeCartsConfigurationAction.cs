using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeCartsConfigurationAction))]
    public partial interface IProjectChangeCartsConfigurationAction : IProjectUpdateAction
    {
        ICartsConfiguration CartsConfiguration { get; set; }
    }
}
