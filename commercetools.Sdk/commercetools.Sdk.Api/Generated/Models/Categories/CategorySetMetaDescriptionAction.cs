using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetMetaDescriptionAction : ICategorySetMetaDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        public CategorySetMetaDescriptionAction()
        { 
           this.Action = "setMetaDescription";
        }
    }
}
