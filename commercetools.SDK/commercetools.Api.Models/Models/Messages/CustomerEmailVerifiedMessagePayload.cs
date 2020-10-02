using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerEmailVerified")]
    public partial class CustomerEmailVerifiedMessagePayload : MessagePayload
    {
        public CustomerEmailVerifiedMessagePayload()
        { 
           this.Type = "CustomerEmailVerified";
        }
    }
}
