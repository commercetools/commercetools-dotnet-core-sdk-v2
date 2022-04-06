using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReturnInfo))]
    public partial interface IReturnInfo
    {
        List<IReturnItem> Items { get; set; }

        string ReturnTrackingId { get; set; }

        string ReturnDate { get; set; }
    }
}
