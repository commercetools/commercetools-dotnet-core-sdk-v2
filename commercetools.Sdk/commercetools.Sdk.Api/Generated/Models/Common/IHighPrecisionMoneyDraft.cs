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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface IHighPrecisionMoneyDraft : ITypedMoneyDraft
    {
        new int FractionDigits { get; set; }

        long PreciseAmount { get; set; }

        new long CentAmount { get; set; }

    }
}
