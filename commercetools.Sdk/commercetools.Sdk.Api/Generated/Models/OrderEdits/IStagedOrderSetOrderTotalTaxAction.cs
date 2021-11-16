using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction))]
    public partial interface IStagedOrderSetOrderTotalTaxAction : IStagedOrderUpdateAction
    {
        IMoney ExternalTotalGross { get; set;}
        
        List<ITaxPortionDraft> ExternalTaxPortions { get; set;}
    }
}
