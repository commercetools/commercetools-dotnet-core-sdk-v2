using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetCustomLineItemsChangeValue))]
    public partial interface IChangeTargetCustomLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        string Predicate { get; set; }

    }
}
