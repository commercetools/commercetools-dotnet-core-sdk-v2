using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdate))]
    public partial interface ITaxCategoryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ITaxCategoryUpdate, ITaxCategoryUpdateAction>
    {
        new long Version { get; set; }
        new IList<ITaxCategoryUpdateAction> Actions { get; set; }
        IEnumerable<ITaxCategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
