using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItem> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public string ReturnDate { get; set;}
    }
}
