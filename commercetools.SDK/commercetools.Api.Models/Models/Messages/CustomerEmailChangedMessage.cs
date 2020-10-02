using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerEmailChanged")]
    public partial class CustomerEmailChangedMessage : Message
    {
        public string Email { get; set;}
        public CustomerEmailChangedMessage()
        { 
           this.Type = "CustomerEmailChanged";
        }
    }
}
