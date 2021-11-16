namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeOrderHintAction : ICategoryChangeOrderHintAction
    {
        public string Action { get; set;}
        
        public string OrderHint { get; set;}
        public CategoryChangeOrderHintAction()
        { 
           this.Action = "changeOrderHint";
        }
    }
}
