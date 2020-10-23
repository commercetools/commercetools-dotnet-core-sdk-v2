using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class CustomerAddressAddedMessagePayload : ICustomerAddressAddedMessagePayload
    {
        public string Type { get; set;}
        
        public IAddress Address { get; set;}
        public CustomerAddressAddedMessagePayload()
        { 
           this.Type = "CustomerAddressAdded";
        }
    }
}
