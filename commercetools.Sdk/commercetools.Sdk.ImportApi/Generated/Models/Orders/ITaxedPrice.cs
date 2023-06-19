using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
