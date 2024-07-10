using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ReturnInfo))]
    public partial interface IReturnInfo
    {
        IList<IReturnItem> Items { get; set; }
        IEnumerable<IReturnItem> ItemsEnumerable { set => Items = value.ToList(); }


        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }

    }
}
