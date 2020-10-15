using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DiscriminatorValue("setDescription")]
    public partial class TaxCategorySetDescriptionAction : TaxCategoryUpdateAction
    {
        public string Description { get; set;}
        public TaxCategorySetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
