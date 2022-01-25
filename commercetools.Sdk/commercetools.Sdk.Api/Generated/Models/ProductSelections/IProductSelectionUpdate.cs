using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionUpdate))]
    public partial interface IProductSelectionUpdate
    {
        long Version { get; set; }

        List<IProductSelectionUpdateAction> Actions { get; set; }
    }
}
