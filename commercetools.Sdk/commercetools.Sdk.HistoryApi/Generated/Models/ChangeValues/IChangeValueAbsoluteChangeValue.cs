using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    public partial interface IChangeValueAbsoluteChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        IList<IMoney> Money { get; set; }
        IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }


    }
}
