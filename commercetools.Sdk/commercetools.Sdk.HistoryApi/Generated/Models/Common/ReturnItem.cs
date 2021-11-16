using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ReturnItem : IReturnItem
    {
        public string Id { get; set;}
        
        public int Quantity { get; set;}
        
        public string Type { get; set;}
        
        public string Comment { get; set;}
        
        public IReturnShipmentState ShipmentState { get; set;}
        
        public IReturnPaymentState PaymentState { get; set;}
        
        public string LastModifiedAt { get; set;}
        
        public string CreatedAt { get; set;}
    }
}
