using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
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
