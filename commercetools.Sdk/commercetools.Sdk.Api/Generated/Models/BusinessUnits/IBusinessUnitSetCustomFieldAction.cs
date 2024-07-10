using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction))]
    public partial interface IBusinessUnitSetCustomFieldAction : IBusinessUnitUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
