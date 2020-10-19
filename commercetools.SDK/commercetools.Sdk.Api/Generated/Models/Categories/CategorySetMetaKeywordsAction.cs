using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setMetaKeywords")]
    public partial class CategorySetMetaKeywordsAction : CategoryUpdateAction
    {
        public LocalizedString MetaKeywords { get; set;}
        public CategorySetMetaKeywordsAction()
        { 
           this.Action = "setMetaKeywords";
        }
    }
}
