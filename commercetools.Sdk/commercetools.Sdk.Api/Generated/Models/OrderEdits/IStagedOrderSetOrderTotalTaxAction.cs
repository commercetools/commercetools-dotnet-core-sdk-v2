using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction))]
    public partial interface IStagedOrderSetOrderTotalTaxAction : IStagedOrderUpdateAction
    {
        IMoney ExternalTotalGross { get; set; }

        List<ITaxPortionDraft> ExternalTaxPortions { get; set; }
    }
}
