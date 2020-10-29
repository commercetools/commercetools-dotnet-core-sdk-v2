using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetCustomerGroupAction : ICustomerSetCustomerGroupAction
    {
        public string Action { get; set;}
        
        public ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public CustomerSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
