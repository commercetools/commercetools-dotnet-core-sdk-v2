using System;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetCustomFieldAction : ICategorySetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CategorySetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
