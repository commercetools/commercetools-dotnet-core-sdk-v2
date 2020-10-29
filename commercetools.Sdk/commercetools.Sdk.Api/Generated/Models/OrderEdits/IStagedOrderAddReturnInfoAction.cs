using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    public interface IStagedOrderAddReturnInfoAction : IStagedOrderUpdateAction
    {
        string ReturnTrackingId { get; set;}
        
        List<IReturnItemDraft> Items { get; set;}
        
        DateTime ReturnDate { get; set;}
    }
}
