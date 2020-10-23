using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CustomerGroups
{
    public interface ICustomerGroupReference : IReference
    {
        ICustomerGroup Obj { get; set;}
    }
}
