using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setCustomer")]
    public partial class ReviewSetCustomerAction : ReviewUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
        public ReviewSetCustomerAction()
        { 
           this.Action = "setCustomer";
        }
    }
}
