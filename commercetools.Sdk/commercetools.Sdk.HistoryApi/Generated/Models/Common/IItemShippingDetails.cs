using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ItemShippingDetails))]
    public partial interface IItemShippingDetails
    {
        IList<IItemShippingTarget> Targets { get; set; }
        IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }


        bool Valid { get; set; }

    }
}
