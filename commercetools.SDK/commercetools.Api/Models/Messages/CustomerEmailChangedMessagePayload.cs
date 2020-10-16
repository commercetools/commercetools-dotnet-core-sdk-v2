using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerEmailChanged")]
    public partial class CustomerEmailChangedMessagePayload : MessagePayload
    {
        public string Email { get; set;}
        public CustomerEmailChangedMessagePayload()
        { 
           this.Type = "CustomerEmailChanged";
        }
    }
}
