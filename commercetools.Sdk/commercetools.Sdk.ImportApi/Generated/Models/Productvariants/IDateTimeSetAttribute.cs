using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    public partial interface IDateTimeSetAttribute : IAttribute
    {
        IList<DateTime> Value { get; set; }
        IEnumerable<DateTime> ValueEnumerable { set => Value = value.ToList(); }


    }
}
