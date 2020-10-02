using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
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
