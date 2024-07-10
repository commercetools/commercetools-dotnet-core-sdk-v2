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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue))]
    public partial interface IChangeValueGiftLineItemChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        IReference Product { get; set; }

        int VariantId { get; set; }

        IReference SupplyChannel { get; set; }

        IReference DistributionChannel { get; set; }

    }
}
