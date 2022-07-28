using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ReturnInfo))]
    public partial interface IReturnInfo
    {
        List<IReturnItemDraft> Items { get; set; }

        string ReturnTrackingId { get; set; }

        DateTime? ReturnDate { get; set; }

    }
}
