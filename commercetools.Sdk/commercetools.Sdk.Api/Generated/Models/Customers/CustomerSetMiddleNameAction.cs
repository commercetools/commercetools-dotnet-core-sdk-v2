using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetMiddleNameAction : ICustomerSetMiddleNameAction
    {
        public string Action { get; set; }

        public string MiddleName { get; set; }
        public CustomerSetMiddleNameAction()
        {
            this.Action = "setMiddleName";
        }
    }
}
