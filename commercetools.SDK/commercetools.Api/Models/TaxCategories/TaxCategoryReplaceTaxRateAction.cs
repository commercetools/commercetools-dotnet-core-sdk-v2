using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
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
