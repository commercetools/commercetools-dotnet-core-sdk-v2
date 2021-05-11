using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderImportDraft))]
    public partial interface IOrderImportDraft 
    {
        string OrderNumber { get; set;}
        
        string CustomerId { get; set;}
        
        string CustomerEmail { get; set;}
        
        List<ILineItemImportDraft> LineItems { get; set;}
        
        List<ICustomLineItemDraft> CustomLineItems { get; set;}
        
        IMoney TotalPrice { get; set;}
        
        ITaxedPriceDraft TaxedPrice { get; set;}
        
        IBaseAddress ShippingAddress { get; set;}
        
        IBaseAddress BillingAddress { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        IOrderState OrderState { get; set;}
        
        IShipmentState ShipmentState { get; set;}
        
        IPaymentState PaymentState { get; set;}
        
        IShippingInfoImportDraft ShippingInfo { get; set;}
        
        DateTime CompletedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IInventoryMode InventoryMode { get; set;}
        
        IRoundingMode TaxRoundingMode { get; set;}
        
        List<IBaseAddress> ItemShippingAddresses { get; set;}
        
        IStoreResourceIdentifier Store { get; set;}
        
        ICartOrigin Origin { get; set;}
    }
}
