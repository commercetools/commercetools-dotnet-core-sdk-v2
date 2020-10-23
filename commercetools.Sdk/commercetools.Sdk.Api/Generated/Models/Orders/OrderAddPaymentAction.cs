using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderAddPaymentAction : IOrderAddPaymentAction
    {
        public string Action { get; set;}
        
        public IPaymentResourceIdentifier Payment { get; set;}
        public OrderAddPaymentAction()
        { 
           this.Action = "addPayment";
        }
    }
}
