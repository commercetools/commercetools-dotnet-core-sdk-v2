using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerEmailVerifiedMessagePayload : ICustomerEmailVerifiedMessagePayload
    {
        public string Type { get; set; }
        public CustomerEmailVerifiedMessagePayload()
        {
            this.Type = "CustomerEmailVerified";
        }
    }
}
