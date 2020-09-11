using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CustomerGroupSetMessagePayload : MessagePayload
    {
        public CustomerGroupReference CustomerGroup { get; set;}
    }
}
