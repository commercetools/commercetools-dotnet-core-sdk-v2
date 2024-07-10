using commercetools.Sdk.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupUpdate : ICustomerGroupUpdate
    {
        public long Version { get; set; }

        public IList<ICustomerGroupUpdateAction> Actions { get; set; }
        public IEnumerable<ICustomerGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
