using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class TaxCategoryReplaceTaxRateAction : ITaxCategoryReplaceTaxRateAction
    {
        public string Action { get; set;}
        
        public string TaxRateId { get; set;}
        
        public ITaxRateDraft TaxRate { get; set;}
        public TaxCategoryReplaceTaxRateAction()
        { 
           this.Action = "replaceTaxRate";
        }
    }
}
