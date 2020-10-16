using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomerGroup")]
    public partial class CustomerSetCustomerGroupAction : CustomerUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public CustomerSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
