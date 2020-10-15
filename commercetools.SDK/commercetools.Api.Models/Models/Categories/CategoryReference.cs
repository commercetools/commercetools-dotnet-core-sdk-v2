using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("category")]
    public partial class CategoryReference : Reference
    {
        public Category Obj { get; set;}
        public CategoryReference()
        { 
           this.TypeId = "category";
        }
    }
}
