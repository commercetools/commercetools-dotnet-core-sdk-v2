using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setDescription")]
    public partial class CategorySetDescriptionAction : CategoryUpdateAction
    {
        public LocalizedString Description { get; set;}
        public CategorySetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
