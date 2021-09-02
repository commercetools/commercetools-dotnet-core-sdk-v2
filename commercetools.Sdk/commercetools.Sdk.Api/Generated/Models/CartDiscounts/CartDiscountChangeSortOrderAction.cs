using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeSortOrderAction : ICartDiscountChangeSortOrderAction
    {
        public string Action { get; set; }

        public string SortOrder { get; set; }
        public CartDiscountChangeSortOrderAction()
        {
            this.Action = "changeSortOrder";
        }
    }
}
