using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerEmailSet")]
    public partial class OrderCustomerEmailSetMessage : Message
    {
        public string Email { get; set;}
        
        public string OldEmail { get; set;}
        public OrderCustomerEmailSetMessage()
        { 
           this.Type = "OrderCustomerEmailSet";
        }
    }
}
