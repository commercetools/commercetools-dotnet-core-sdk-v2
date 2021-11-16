using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeNameAction : ICategoryChangeNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public CategoryChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
