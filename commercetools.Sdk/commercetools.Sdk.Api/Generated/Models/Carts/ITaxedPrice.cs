using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedPrice))]
    public partial interface ITaxedPrice
    {
        ITypedMoney TotalNet { get; set; }

        ITypedMoney TotalGross { get; set; }

        IList<ITaxPortion> TaxPortions { get; set; }
        IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


        ITypedMoney TotalTax { get; set; }

    }
}
