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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryDraft))]
    public partial interface ITaxCategoryDraft
    {
        string Name { get; set; }

        string Description { get; set; }

        IList<ITaxRateDraft> Rates { get; set; }
        IEnumerable<ITaxRateDraft> RatesEnumerable { set => Rates = value.ToList(); }


        string Key { get; set; }

    }
}
