using commercetools.Sdk.ImportApi.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

        IList<ITaxPortion> TaxPortions { get; set; }
        IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


    }
}
