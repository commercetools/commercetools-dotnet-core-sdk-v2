using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItemDraft> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public DateTime? ReturnDate { get; set;}
    }
}
