using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Money))]
    public partial interface IMoney
    {
        long CentAmount { get; set; }

        string CurrencyCode { get; set; }

    }
}
