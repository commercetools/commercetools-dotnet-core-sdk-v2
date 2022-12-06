using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionUpdate))]
    public partial interface IProductSelectionUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductSelectionUpdate, IProductSelectionUpdateAction>
    {
        new long Version { get; set; }
        new IList<IProductSelectionUpdateAction> Actions { get; set; }
        IEnumerable<IProductSelectionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
