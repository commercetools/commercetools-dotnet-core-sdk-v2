using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdate))]
    public partial interface ITaxCategoryUpdate
    {
        long Version { get; set; }

        List<ITaxCategoryUpdateAction> Actions { get; set; }
    }
}
