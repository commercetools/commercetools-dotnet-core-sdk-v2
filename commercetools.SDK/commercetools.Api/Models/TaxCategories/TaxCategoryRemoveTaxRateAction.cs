using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DiscriminatorValue("removeTaxRate")]
    public partial class TaxCategoryRemoveTaxRateAction : TaxCategoryUpdateAction
    {
        public string TaxRateId { get; set;}
        public TaxCategoryRemoveTaxRateAction()
        { 
           this.Action = "removeTaxRate";
        }
    }
}
