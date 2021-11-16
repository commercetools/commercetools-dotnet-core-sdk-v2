using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItemDraft> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public DateTime? ReturnDate { get; set;}
    }
}
