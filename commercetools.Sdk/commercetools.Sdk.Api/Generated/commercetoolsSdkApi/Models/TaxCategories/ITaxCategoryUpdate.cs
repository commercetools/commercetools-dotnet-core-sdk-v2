using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdate))]
    public partial interface ITaxCategoryUpdate
    {
        long Version { get; set; }

        IList<ITaxCategoryUpdateAction> Actions { get; set; }

        IEnumerable<ITaxCategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
