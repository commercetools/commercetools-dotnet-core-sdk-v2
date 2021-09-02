using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupUpdateAction : ICustomerGroupUpdateAction
    {
        public string Action { get; set; }
    }
}
