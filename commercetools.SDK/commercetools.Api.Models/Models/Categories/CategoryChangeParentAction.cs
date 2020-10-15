using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("changeParent")]
    public partial class CategoryChangeParentAction : CategoryUpdateAction
    {
        public CategoryResourceIdentifier Parent { get; set;}
        public CategoryChangeParentAction()
        { 
           this.Action = "changeParent";
        }
    }
}
