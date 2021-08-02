using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupDraft : ICustomerGroupDraft
    {
        public string Key { get; set;}
        
        public string GroupName { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
    }
}
