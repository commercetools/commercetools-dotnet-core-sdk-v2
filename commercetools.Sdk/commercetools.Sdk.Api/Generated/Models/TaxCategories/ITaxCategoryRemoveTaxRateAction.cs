using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    public partial interface ITaxCategoryRemoveTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }
    }
}
