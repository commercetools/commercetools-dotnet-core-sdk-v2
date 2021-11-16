using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeCartsConfiguration))]
    public partial interface IProjectChangeCartsConfiguration : IProjectUpdateAction
    {
        ICartsConfiguration CartsConfiguration { get; set; }
    }
}
