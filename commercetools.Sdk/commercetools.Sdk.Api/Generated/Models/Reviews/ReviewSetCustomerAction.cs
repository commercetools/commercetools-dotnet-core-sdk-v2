using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetCustomerAction : IReviewSetCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public ReviewSetCustomerAction()
        {
            this.Action = "setCustomer";
        }
    }
}
