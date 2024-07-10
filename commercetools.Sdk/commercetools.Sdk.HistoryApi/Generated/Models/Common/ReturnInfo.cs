using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ReturnInfo : IReturnInfo
    {
        public IList<IReturnItem> Items { get; set; }
        public IEnumerable<IReturnItem> ItemsEnumerable { set => Items = value.ToList(); }


        public string ReturnTrackingId { get; set; }

        public string ReturnDate { get; set; }
    }
}
