using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

        List<ITaxPortion> TaxPortions { get; set; }

        IMoney TotalTax { get; set; }

    }
}
