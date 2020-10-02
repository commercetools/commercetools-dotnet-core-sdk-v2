using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerEmailSet")]
    public partial class OrderCustomerEmailSetMessagePayload : MessagePayload
    {
        public string Email { get; set;}
        
        public string OldEmail { get; set;}
        public OrderCustomerEmailSetMessagePayload()
        { 
           this.Type = "OrderCustomerEmailSet";
        }
    }
}
