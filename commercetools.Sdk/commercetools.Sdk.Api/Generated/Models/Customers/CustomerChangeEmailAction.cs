using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerChangeEmailAction : ICustomerChangeEmailAction
    {
        public string Action { get; set; }

        public string Email { get; set; }
        public CustomerChangeEmailAction()
        {
            this.Action = "changeEmail";
        }
    }
}
