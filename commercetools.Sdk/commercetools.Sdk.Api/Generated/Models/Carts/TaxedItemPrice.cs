using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ICentPrecisionMoney TotalNet { get; set; }

        public ICentPrecisionMoney TotalGross { get; set; }

        public IList<ITaxPortion> TaxPortions { get; set; }
        public IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


        public ICentPrecisionMoney TotalTax { get; set; }
    }
}
