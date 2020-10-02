using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
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
