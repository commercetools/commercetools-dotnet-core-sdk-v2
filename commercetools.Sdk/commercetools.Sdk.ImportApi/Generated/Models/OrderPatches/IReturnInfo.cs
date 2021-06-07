using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ReturnInfo))]
    public partial interface IReturnInfo 
    {
        List<IReturnItemDraft> Items { get; set;}
        
        string ReturnTrackingId { get; set;}
        
        DateTime ReturnDate { get; set;}
    }
}
