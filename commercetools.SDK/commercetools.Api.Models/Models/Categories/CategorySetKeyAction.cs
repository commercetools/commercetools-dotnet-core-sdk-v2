using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setKey")]
    public partial class CategorySetKeyAction : CategoryUpdateAction
    {
        public string Key { get; set;}
        public CategorySetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
