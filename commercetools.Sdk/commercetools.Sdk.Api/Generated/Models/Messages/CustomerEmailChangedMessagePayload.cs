using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerEmailChangedMessagePayload : ICustomerEmailChangedMessagePayload
    {
        public string Type { get; set; }

        public string Email { get; set; }
        public CustomerEmailChangedMessagePayload()
        {
            this.Type = "CustomerEmailChanged";
        }
    }
}
