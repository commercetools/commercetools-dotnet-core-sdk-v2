using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction))]
    public interface ICustomerGroupSetCustomTypeAction : ICustomerGroupUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
