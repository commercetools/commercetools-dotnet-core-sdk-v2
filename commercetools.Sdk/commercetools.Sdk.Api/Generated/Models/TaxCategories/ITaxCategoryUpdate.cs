using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdate))]
    public partial interface ITaxCategoryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ITaxCategoryUpdate, ITaxCategoryUpdateAction>
    {
        new long Version { get; set; }
        new List<ITaxCategoryUpdateAction> Actions { get; set; }

    }
}
