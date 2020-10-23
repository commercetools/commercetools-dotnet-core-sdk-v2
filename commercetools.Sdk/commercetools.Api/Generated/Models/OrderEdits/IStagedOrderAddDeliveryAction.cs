using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderAddDeliveryAction : IStagedOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set;}
        
        IAddress Address { get; set;}
        
        List<IParcelDraft> Parcels { get; set;}
    }
}
