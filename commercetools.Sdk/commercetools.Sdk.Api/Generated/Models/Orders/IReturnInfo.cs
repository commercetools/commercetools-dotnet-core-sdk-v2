using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ReturnInfo))]
    public partial interface IReturnInfo
    {
        List<IReturnItem> Items { get; set; }

        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }

    }
}
