using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetVatIdAction : ICustomerSetVatIdAction
    {
        public string Action { get; set; }

        public string VatId { get; set; }
        public CustomerSetVatIdAction()
        {
            this.Action = "setVatId";
        }
    }
}
