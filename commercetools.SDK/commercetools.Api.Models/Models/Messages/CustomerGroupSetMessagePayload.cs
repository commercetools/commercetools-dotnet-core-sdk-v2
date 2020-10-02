using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerGroupSet")]
    public partial class CustomerGroupSetMessagePayload : MessagePayload
    {
        public CustomerGroupReference CustomerGroup { get; set;}
        public CustomerGroupSetMessagePayload()
        { 
           this.Type = "CustomerGroupSet";
        }
    }
}
