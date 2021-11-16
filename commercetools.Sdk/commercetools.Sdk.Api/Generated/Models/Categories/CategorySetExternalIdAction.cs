namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetExternalIdAction : ICategorySetExternalIdAction
    {
        public string Action { get; set;}
        
        public string ExternalId { get; set;}
        public CategorySetExternalIdAction()
        { 
           this.Action = "setExternalId";
        }
    }
}
