using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetLastNameAction : ICustomerSetLastNameAction
    {
        public string Action { get; set;}
        
        public string LastName { get; set;}
        public CustomerSetLastNameAction()
        { 
           this.Action = "setLastName";
        }
    }
}
