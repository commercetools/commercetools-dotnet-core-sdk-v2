using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class InvalidItemShippingDetailsError : ErrorObject
    {
        public string Subject { get; set;}
        
        public string ItemId { get; set;}
    }
}
