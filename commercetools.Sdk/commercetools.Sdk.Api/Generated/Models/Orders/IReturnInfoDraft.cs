using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ReturnInfoDraft))]
    public partial interface IReturnInfoDraft
    {
        List<IReturnItemDraft> Items { get; set; }

        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }
    }
}
