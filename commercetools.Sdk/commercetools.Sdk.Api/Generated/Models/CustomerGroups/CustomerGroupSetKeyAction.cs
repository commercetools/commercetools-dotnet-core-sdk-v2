using commercetools.Sdk.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupSetKeyAction : ICustomerGroupSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public CustomerGroupSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
