using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomerNumber")]
    public partial class CustomerSetCustomerNumberAction : CustomerUpdateAction
    {
        public string CustomerNumber { get; set;}
        public CustomerSetCustomerNumberAction()
        { 
           this.Action = "setCustomerNumber";
        }
    }
}
