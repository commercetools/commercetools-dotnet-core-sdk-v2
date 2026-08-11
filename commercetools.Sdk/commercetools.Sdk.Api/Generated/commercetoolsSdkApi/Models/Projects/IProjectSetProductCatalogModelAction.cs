using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetProductCatalogModelAction))]
    public partial interface IProjectSetProductCatalogModelAction : IProjectUpdateAction
    {
        IProductCatalogModel ProductCatalogModel { get; set; }

    }
}
