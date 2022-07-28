using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryDraft))]
    public partial interface ITaxCategoryDraft
    {
        string Name { get; set; }

        string Description { get; set; }

        List<ITaxRateDraft> Rates { get; set; }

        string Key { get; set; }

    }
}
