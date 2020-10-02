using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderBillingAddressSet")]
    public partial class OrderBillingAddressSetMessage : Message
    {
        public Address Address { get; set;}
        
        public Address OldAddress { get; set;}
        public OrderBillingAddressSetMessage()
        { 
           this.Type = "OrderBillingAddressSet";
        }
    }
}
