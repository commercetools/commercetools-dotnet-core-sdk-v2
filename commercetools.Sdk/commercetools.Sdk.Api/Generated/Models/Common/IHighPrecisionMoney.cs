using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoney))]
    public partial interface IHighPrecisionMoney : ITypedMoney
    {
        long PreciseAmount { get; set; }

        new int FractionDigits { get; set; }

    }
}
