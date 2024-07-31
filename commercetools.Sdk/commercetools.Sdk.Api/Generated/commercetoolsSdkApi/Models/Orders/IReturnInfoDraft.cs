using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ReturnInfoDraft))]
    public partial interface IReturnInfoDraft
    {
        IList<IReturnItemDraft> Items { get; set; }

        IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }

        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }

    }
}
