using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField))]
    public partial interface IMoneySetField : ICustomField
    {
        IList<IMoney> Value { get; set; }
        IEnumerable<IMoney> ValueEnumerable { set => Value = value.ToList(); }


    }
}
