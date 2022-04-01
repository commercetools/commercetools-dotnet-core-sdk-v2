using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    public partial interface IStagedOrderAddReturnInfoAction : IStagedOrderUpdateAction
    {
        string ReturnTrackingId { get; set; }

        List<IReturnItemDraft> Items { get; set; }

        DateTime? ReturnDate { get; set; }
    }
}
