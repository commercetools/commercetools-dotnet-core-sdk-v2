using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setLastName")]
    public partial class CustomerSetLastNameAction : CustomerUpdateAction
    {
        public string LastName { get; set;}
        public CustomerSetLastNameAction()
        { 
           this.Action = "setLastName";
        }
    }
}
