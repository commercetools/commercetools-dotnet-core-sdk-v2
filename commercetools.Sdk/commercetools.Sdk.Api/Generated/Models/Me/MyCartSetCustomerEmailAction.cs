using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetCustomerEmailAction : IMyCartSetCustomerEmailAction
    {
        public string Action { get; set;}
        
        public string Email { get; set;}
        public MyCartSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
