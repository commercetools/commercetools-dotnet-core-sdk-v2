using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidItemShippingDetails")]
    public partial class InvalidItemShippingDetailsError : ErrorObject
    {
        public string Subject { get; set;}
        
        public string ItemId { get; set;}
        public InvalidItemShippingDetailsError()
        { 
           this.Code = "InvalidItemShippingDetails";
        }
    }
}
