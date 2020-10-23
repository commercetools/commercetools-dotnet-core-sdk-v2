using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupReference))]
    public interface ICustomerGroupReference : IReference
    {
        ICustomerGroup Obj { get; set;}
    }
}
