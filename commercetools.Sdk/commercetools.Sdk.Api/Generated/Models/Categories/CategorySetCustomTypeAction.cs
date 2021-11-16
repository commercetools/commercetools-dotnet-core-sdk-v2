using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetCustomTypeAction : ICategorySetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public CategorySetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
