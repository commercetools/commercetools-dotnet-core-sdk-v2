using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetSalutationAction : ICustomerSetSalutationAction
    {
        public string Action { get; set; }

        public string Salutation { get; set; }
        public CustomerSetSalutationAction()
        {
            this.Action = "setSalutation";
        }
    }
}
