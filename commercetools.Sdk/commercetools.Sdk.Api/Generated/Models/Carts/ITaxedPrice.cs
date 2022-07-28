using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        ITypedMoney TotalNet { get; set; }

        ITypedMoney TotalGross { get; set; }

        List<ITaxPortion> TaxPortions { get; set; }

        ITypedMoney TotalTax { get; set; }

    }
}
