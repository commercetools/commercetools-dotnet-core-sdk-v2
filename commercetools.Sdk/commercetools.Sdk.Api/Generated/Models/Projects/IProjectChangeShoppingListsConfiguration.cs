using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeShoppingListsConfiguration))]
    public partial interface IProjectChangeShoppingListsConfiguration : IProjectUpdateAction
    {
        IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }
    }
}
