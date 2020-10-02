using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("replaceTaxRate")]
    public partial class TaxCategoryReplaceTaxRateAction : TaxCategoryUpdateAction
    {
        public string TaxRateId { get; set;}
        
        public TaxRateDraft TaxRate { get; set;}
        public TaxCategoryReplaceTaxRateAction()
        { 
           this.Action = "replaceTaxRate";
        }
    }
}
