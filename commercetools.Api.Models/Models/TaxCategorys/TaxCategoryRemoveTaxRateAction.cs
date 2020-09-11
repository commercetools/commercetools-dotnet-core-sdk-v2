using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    public class TaxCategoryRemoveTaxRateAction : TaxCategoryUpdateAction
    {
        public string TaxRateId { get; set;}
    }
}
