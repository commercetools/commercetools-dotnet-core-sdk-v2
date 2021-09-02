using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
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
