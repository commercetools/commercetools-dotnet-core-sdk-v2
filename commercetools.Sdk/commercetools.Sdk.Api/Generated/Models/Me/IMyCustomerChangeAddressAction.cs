using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction))]
    public partial interface IMyCustomerChangeAddressAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

        IBaseAddress Address { get; set; }

    }
}
