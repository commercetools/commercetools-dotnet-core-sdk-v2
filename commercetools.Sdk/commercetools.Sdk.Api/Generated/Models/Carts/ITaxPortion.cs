using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxPortion))]
    public partial interface ITaxPortion
    {
        string Name { get; set; }

        decimal Rate { get; set; }

        ICentPrecisionMoney Amount { get; set; }

    }
}
