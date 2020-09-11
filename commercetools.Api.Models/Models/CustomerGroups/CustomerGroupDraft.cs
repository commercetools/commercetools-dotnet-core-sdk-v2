using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupDraft 
    {
        public string Key { get; set;}
        
        public string GroupName { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
