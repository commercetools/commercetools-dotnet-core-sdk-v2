using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("removeTaxRate")]
    public class TaxCategoryRemoveTaxRateAction : TaxCategoryUpdateAction
    {
        public string TaxRateId { get; set;}
    }
}
