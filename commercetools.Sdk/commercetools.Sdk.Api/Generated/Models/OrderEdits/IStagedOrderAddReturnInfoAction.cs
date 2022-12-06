using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    public partial interface IStagedOrderAddReturnInfoAction : IStagedOrderUpdateAction
    {
        string ReturnTrackingId { get; set; }

        IList<IReturnItemDraft> Items { get; set; }
        IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }


        DateTime? ReturnDate { get; set; }

    }
}
