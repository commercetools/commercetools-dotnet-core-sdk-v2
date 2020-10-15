using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<CategoryUpdateAction> Actions { get; set;}
    }
}
