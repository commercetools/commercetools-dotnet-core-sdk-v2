using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        IList<IItemShippingTarget> Targets { get; set; }
        IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }


    }
}
