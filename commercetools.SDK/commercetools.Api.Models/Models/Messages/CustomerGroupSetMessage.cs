using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerGroupSet")]
    public class CustomerGroupSetMessage : Message
    {
        public CustomerGroupReference CustomerGroup { get; set;}
    }
}
