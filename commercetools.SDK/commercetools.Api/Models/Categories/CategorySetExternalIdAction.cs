using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setExternalId")]
    public partial class CategorySetExternalIdAction : CategoryUpdateAction
    {
        public string ExternalId { get; set;}
        public CategorySetExternalIdAction()
        { 
           this.Action = "setExternalId";
        }
    }
}
