using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public class PaymentStatus 
    {
        public string InterfaceCode { get; set;}
        
        public string InterfaceText { get; set;}
        
        public StateReference State { get; set;}
    }
}
