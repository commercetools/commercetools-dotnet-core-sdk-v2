using commercetools.Sdk.ImportApi.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute))]
    public partial interface IMoneySetAttribute : IAttribute
    {
        IList<ITypedMoney> Value { get; set; }
        IEnumerable<ITypedMoney> ValueEnumerable { set => Value = value.ToList(); }


    }
}
