using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerPasswordTokenCreatedMessagePayload : ICustomerPasswordTokenCreatedMessagePayload
    {
        public string Type { get; set; }

        public string CustomerId { get; set; }

        public DateTime ExpiresAt { get; set; }
        public CustomerPasswordTokenCreatedMessagePayload()
        {
            this.Type = "CustomerPasswordTokenCreated";
        }
    }
}
