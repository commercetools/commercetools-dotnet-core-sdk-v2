using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerGroupSet")]
    public partial class CustomerGroupSetMessage : Message
    {
        public CustomerGroupReference CustomerGroup { get; set;}
        public CustomerGroupSetMessage()
        { 
           this.Type = "CustomerGroupSet";
        }
    }
}
