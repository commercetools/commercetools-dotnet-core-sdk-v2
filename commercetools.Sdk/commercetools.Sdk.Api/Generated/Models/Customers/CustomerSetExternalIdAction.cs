using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetExternalIdAction : ICustomerSetExternalIdAction
    {
        public string Action { get; set; }

        public string ExternalId { get; set; }
        public CustomerSetExternalIdAction()
        {
            this.Action = "setExternalId";
        }
    }
}
