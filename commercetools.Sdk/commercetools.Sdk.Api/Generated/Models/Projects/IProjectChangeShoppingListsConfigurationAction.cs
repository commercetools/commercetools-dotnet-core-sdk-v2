using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction))]
    public partial interface IProjectChangeShoppingListsConfigurationAction : IProjectUpdateAction
    {
        IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }
    }
}
