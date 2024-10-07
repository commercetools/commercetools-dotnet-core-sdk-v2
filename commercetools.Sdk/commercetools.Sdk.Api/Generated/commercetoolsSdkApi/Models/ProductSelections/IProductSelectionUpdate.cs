using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionUpdate))]
    public partial interface IProductSelectionUpdate
    {
        long Version { get; set; }

        IList<IProductSelectionUpdateAction> Actions { get; set; }

        IEnumerable<IProductSelectionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
