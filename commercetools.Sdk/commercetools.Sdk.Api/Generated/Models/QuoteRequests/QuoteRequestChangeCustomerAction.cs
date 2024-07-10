using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestChangeCustomerAction : IQuoteRequestChangeCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public QuoteRequestChangeCustomerAction()
        {
            this.Action = "changeCustomer";
        }
    }
}
