using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CustomerGroups
{
    public interface ICustomerGroupDraft 
    {
        string Key { get; set;}
        
        string GroupName { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
