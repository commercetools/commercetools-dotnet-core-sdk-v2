using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetLastNameAction : ICustomerSetLastNameAction
    {
        public string Action { get; set; }

        public string LastName { get; set; }
        public CustomerSetLastNameAction()
        {
            this.Action = "setLastName";
        }
    }
}
