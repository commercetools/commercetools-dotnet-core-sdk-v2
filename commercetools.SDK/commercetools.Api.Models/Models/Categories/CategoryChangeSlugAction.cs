using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
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
