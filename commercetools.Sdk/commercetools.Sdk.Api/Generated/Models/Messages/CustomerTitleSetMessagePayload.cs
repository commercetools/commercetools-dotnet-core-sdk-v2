using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerTitleSetMessagePayload : ICustomerTitleSetMessagePayload
    {
        public string Type { get; set;}
        
        public string Title { get; set;}
        public CustomerTitleSetMessagePayload()
        { 
           this.Type = "CustomerTitleSet";
        }
    }
}
