using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("DeliveryAddressSet")]
    public partial class DeliveryAddressSetMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public Address Address { get; set;}
        
        public Address OldAddress { get; set;}
        public DeliveryAddressSetMessage()
        { 
           this.Type = "DeliveryAddressSet";
        }
    }
}
