using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setMetaDescription")]
    public partial class CategorySetMetaDescriptionAction : CategoryUpdateAction
    {
        public LocalizedString MetaDescription { get; set;}
        public CategorySetMetaDescriptionAction()
        { 
           this.Action = "setMetaDescription";
        }
    }
}
