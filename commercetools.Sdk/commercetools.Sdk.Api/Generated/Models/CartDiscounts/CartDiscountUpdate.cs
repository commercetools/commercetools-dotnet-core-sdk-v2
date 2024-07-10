using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountUpdate : ICartDiscountUpdate
    {
        public long Version { get; set; }

        public IList<ICartDiscountUpdateAction> Actions { get; set; }
        public IEnumerable<ICartDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
