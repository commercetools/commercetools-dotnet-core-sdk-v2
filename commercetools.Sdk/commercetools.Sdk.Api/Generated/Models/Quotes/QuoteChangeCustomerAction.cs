using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteChangeCustomerAction : IQuoteChangeCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public QuoteChangeCustomerAction()
        {
            this.Action = "changeCustomer";
        }
    }
}
