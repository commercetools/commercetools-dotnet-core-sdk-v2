using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetAddressCustomFieldAction : ICustomerSetAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerSetAddressCustomFieldAction()
        {
            this.Action = "setAddressCustomField";
        }
    }
}
