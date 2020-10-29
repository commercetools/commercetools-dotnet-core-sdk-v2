using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetDateOfBirthAction : ICustomerSetDateOfBirthAction
    {
        public string Action { get; set;}
        
        public DateTime DateOfBirth { get; set;}
        public CustomerSetDateOfBirthAction()
        { 
           this.Action = "setDateOfBirth";
        }
    }
}
