using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.Stores;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderImportDraft 
    {
        string OrderNumber { get; set;}
        
        string CustomerId { get; set;}
        
        string CustomerEmail { get; set;}
        
        List<ILineItemImportDraft> LineItems { get; set;}
        
        List<ICustomLineItemDraft> CustomLineItems { get; set;}
        
        IMoney TotalPrice { get; set;}
        
        ITaxedPriceDraft TaxedPrice { get; set;}
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        string OrderState { get; set;}
        
        OrderState OrderStateAsEnum { get; }
        
        string ShipmentState { get; set;}
        
        ShipmentState ShipmentStateAsEnum { get; }
        
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
        
        IShippingInfoImportDraft ShippingInfo { get; set;}
        
        DateTime CompletedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string InventoryMode { get; set;}
        
        InventoryMode InventoryModeAsEnum { get; }
        
        string TaxRoundingMode { get; set;}
        
        RoundingMode TaxRoundingModeAsEnum { get; }
        
        List<IAddress> ItemShippingAddresses { get; set;}
        
        IStoreResourceIdentifier Store { get; set;}
        
        string Origin { get; set;}
        
        CartOrigin OriginAsEnum { get; }
    }
}
