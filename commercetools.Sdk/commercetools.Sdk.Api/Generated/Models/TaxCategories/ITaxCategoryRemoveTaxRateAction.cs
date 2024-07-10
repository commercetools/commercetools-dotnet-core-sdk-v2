using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    public partial interface ITaxCategoryRemoveTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }

        string TaxRateKey { get; set; }

    }
}
