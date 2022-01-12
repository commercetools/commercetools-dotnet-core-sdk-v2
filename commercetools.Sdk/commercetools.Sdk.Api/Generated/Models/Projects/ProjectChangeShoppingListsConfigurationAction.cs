namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeShoppingListsConfigurationAction : IProjectChangeShoppingListsConfigurationAction
    {
        public string Action { get; set; }

        public IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }
        public ProjectChangeShoppingListsConfigurationAction()
        {
            this.Action = "changeShoppingListsConfiguration";
        }
    }
}
