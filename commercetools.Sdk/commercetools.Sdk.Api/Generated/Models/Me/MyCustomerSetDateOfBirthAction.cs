using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyCustomerSetDateOfBirthAction : IMyCustomerSetDateOfBirthAction
    {
        public string Action { get; set;}
        
        public DateTime DateOfBirth { get; set;}
        public MyCustomerSetDateOfBirthAction()
        { 
           this.Action = "setDateOfBirth";
        }
    }
}
