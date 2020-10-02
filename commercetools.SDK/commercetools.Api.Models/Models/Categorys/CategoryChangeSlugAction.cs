using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeSlug")]
    public partial class CategoryChangeSlugAction : CategoryUpdateAction
    {
        public LocalizedString Slug { get; set;}
        public CategoryChangeSlugAction()
        { 
           this.Action = "changeSlug";
        }
    }
}
