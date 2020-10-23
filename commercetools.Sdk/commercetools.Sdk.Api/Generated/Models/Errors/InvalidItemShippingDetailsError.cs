using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public  partial class InvalidItemShippingDetailsError : IInvalidItemShippingDetailsError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string Subject { get; set;}
        
        public string ItemId { get; set;}
        public InvalidItemShippingDetailsError()
        { 
           this.Code = "InvalidItemShippingDetails";
        }
    }
}
