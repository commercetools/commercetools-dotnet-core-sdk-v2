using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditDraft))]
    public partial interface IOrderEditDraft 
    {
        string Key { get; set;}
        
        IOrderReference Resource { get; set;}
        
        List<IStagedOrderUpdateAction> StagedActions { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Comment { get; set;}
        
        bool? DryRun { get; set;}
    }
}
