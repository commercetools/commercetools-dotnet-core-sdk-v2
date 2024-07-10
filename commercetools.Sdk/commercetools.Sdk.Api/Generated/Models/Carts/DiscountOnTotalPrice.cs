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

    public partial class DiscountOnTotalPrice : IDiscountOnTotalPrice
    {
        public ITypedMoney DiscountedAmount { get; set; }

        public IList<IDiscountedTotalPricePortion> IncludedDiscounts { get; set; }
        public IEnumerable<IDiscountedTotalPricePortion> IncludedDiscountsEnumerable { set => IncludedDiscounts = value.ToList(); }


        public ITypedMoney DiscountedNetAmount { get; set; }

        public ITypedMoney DiscountedGrossAmount { get; set; }
    }
}
