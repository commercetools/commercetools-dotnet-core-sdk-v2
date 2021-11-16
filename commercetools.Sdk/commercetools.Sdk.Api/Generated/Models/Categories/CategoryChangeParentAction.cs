namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeParentAction : ICategoryChangeParentAction
    {
        public string Action { get; set; }

        public ICategoryResourceIdentifier Parent { get; set; }
        public CategoryChangeParentAction()
        {
            this.Action = "changeParent";
        }
    }
}
