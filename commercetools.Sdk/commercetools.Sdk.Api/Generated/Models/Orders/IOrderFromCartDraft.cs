using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderFromCartDraft))]
    public partial interface IOrderFromCartDraft 
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        string Id { get; set;}
        
        ICartResourceIdentifier Cart { get; set;}
        
        long Version { get; set;}
        
        string OrderNumber { get; set;}
        
        IPaymentState PaymentState { get; set;}
        
        IShipmentState ShipmentState { get; set;}
        
        IOrderState OrderState { get; set;}
        
        IStateResourceIdentifier State { get; set;}
    }
}
