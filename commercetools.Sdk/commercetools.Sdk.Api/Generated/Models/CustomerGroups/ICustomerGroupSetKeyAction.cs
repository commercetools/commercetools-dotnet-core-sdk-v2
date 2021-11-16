using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupSetKeyAction))]
    public partial interface ICustomerGroupSetKeyAction : ICustomerGroupUpdateAction
    {
        string Key { get; set;}
    }
}
