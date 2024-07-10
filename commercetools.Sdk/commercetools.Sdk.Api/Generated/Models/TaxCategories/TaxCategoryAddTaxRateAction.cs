using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryAddTaxRateAction : ITaxCategoryAddTaxRateAction
    {
        public string Action { get; set; }

        public ITaxRateDraft TaxRate { get; set; }
        public TaxCategoryAddTaxRateAction()
        {
            this.Action = "addTaxRate";
        }
    }
}
