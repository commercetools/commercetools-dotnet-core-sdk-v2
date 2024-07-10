using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAddressAction))]
    public partial interface IBusinessUnitChangeAddressAction : IBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

        IBaseAddress Address { get; set; }

    }
}
