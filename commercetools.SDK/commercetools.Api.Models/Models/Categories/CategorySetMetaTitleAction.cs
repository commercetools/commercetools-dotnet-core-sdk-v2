using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setMetaTitle")]
    public partial class CategorySetMetaTitleAction : CategoryUpdateAction
    {
        public LocalizedString MetaTitle { get; set;}
        public CategorySetMetaTitleAction()
        { 
           this.Action = "setMetaTitle";
        }
    }
}
