using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetAddressCustomTypeAction : ICustomerSetAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CustomerSetAddressCustomTypeAction()
        {
            this.Action = "setAddressCustomType";
        }
    }
}
