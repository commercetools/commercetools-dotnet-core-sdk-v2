using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction))]
    public partial interface ICustomerGroupSetCustomFieldAction : ICustomerGroupUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
