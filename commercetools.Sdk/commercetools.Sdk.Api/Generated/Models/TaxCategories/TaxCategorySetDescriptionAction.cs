using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class TaxCategorySetDescriptionAction : ITaxCategorySetDescriptionAction
    {
        public string Action { get; set;}
        
        public string Description { get; set;}
        public TaxCategorySetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
