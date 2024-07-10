using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        decimal Amount { get; set; }

    }
}
