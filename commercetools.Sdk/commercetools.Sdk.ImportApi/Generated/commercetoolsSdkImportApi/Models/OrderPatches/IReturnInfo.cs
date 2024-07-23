using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ReturnInfo))]
    public partial interface IReturnInfo
    {
        IList<IReturnItemDraft> Items { get; set; }
        IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }


        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }

    }
}
