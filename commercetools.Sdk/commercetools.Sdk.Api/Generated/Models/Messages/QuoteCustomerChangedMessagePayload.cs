using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteCustomerChangedMessagePayload : IQuoteCustomerChangedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerReference PreviousCustomer { get; set; }
        public QuoteCustomerChangedMessagePayload()
        {
            this.Type = "QuoteCustomerChanged";
        }
    }
}
