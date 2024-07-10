using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
