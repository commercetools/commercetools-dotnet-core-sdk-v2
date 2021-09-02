using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ReturnInfo))]
    public partial interface IReturnInfo
    {
        List<IReturnItem> Items { get; set; }

        string ReturnTrackingId { get; set; }

        string ReturnDate { get; set; }
    }
}
