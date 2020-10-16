using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupDraft 
    {
        public string Key { get; set;}
        
        public string GroupName { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
