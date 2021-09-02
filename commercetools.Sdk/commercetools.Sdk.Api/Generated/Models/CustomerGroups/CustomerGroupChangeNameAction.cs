using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupChangeNameAction : ICustomerGroupChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public CustomerGroupChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
