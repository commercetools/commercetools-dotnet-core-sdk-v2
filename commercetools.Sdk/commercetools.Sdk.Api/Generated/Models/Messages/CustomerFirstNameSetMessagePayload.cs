using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerFirstNameSetMessagePayload : ICustomerFirstNameSetMessagePayload
    {
        public string Type { get; set;}
        
        public string FirstName { get; set;}
        public CustomerFirstNameSetMessagePayload()
        { 
           this.Type = "CustomerFirstNameSet";
        }
    }
}
