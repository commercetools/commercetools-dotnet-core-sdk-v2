using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionUpdate))]
    public partial interface IProductSelectionUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductSelectionUpdate, IProductSelectionUpdateAction>
    {
        new long Version { get; set; }
        new List<IProductSelectionUpdateAction> Actions { get; set; }
    }
}
