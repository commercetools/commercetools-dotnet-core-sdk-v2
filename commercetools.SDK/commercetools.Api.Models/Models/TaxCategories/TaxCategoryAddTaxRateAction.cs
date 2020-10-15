using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DiscriminatorValue("addTaxRate")]
    public partial class TaxCategoryAddTaxRateAction : TaxCategoryUpdateAction
    {
        public TaxRateDraft TaxRate { get; set;}
        public TaxCategoryAddTaxRateAction()
        { 
           this.Action = "addTaxRate";
        }
    }
}
