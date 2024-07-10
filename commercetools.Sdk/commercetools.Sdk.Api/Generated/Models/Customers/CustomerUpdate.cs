using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerUpdate : ICustomerUpdate
    {
        public long Version { get; set; }

        public IList<ICustomerUpdateAction> Actions { get; set; }
        public IEnumerable<ICustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
