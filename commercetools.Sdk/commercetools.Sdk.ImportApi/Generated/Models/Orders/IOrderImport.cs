using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.OrderImport))]
    public partial interface IOrderImport 
    {
        string OrderNumber { get; set;}
        
        ICustomerKeyReference Customer { get; set;}
        
        string CustomerEmail { get; set;}
        
        List<ILineItemImportDraft> LineItems { get; set;}
        
        List<ICustomLineItemDraft> CustomLineItems { get; set;}
        
        ITypedMoney TotalPrice { get; set;}
        
        ITaxedPrice TaxedPrice { get; set;}
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        ICustomerGroupKeyReference CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        IOrderState OrderState { get; set;}
        
        IShipmentState ShipmentState { get; set;}
        
        IPaymentState PaymentState { get; set;}
        
        IShippingInfoImportDraft ShippingInfo { get; set;}
        
        DateTime? CompletedAt { get; set;}
        
        ICustom Custom { get; set;}
        
        IInventoryMode InventoryMode { get; set;}
        
        IRoundingMode TaxRoundingMode { get; set;}
        
        ITaxCalculationMode TaxCalculationMode { get; set;}
        
        ICartOrigin Origin { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
    }
}
