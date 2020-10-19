using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerCompanyNameSet")]
    public partial class CustomerCompanyNameSetMessage : Message
    {
        public string CompanyName { get; set;}
        public CustomerCompanyNameSetMessage()
        { 
           this.Type = "CustomerCompanyNameSet";
        }
    }
}
