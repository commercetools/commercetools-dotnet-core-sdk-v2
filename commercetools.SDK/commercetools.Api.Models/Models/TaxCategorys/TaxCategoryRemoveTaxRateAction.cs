using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
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
