using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setCustomField")]
    public partial class CategorySetCustomFieldAction : CategoryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CategorySetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
