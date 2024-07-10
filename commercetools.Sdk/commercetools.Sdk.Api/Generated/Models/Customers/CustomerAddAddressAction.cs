using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerAddAddressAction : ICustomerAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CustomerAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
