using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction))]
    public partial interface IProjectChangeShoppingListsConfigurationAction : IProjectUpdateAction
    {
        IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }

    }
}
