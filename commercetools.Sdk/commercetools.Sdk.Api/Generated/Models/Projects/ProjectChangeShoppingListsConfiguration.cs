namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeShoppingListsConfiguration : IProjectChangeShoppingListsConfiguration
    {
        public string Action { get; set; }

        public IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }
        public ProjectChangeShoppingListsConfiguration()
        {
            this.Action = "changeShoppingListsConfiguration";
        }
    }
}
