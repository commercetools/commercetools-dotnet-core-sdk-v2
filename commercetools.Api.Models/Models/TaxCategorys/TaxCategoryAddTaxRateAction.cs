using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    public class TaxCategoryAddTaxRateAction : TaxCategoryUpdateAction
    {
        public TaxRateDraft TaxRate { get; set;}
    }
}
