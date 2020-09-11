using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupChangeNameAction : CustomerGroupUpdateAction
    {
        public string Name { get; set;}
    }
}
