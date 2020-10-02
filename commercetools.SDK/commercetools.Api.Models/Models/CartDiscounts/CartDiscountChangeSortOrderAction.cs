using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeSortOrder")]
    public partial class CartDiscountChangeSortOrderAction : CartDiscountUpdateAction
    {
        public string SortOrder { get; set;}
        public CartDiscountChangeSortOrderAction()
        { 
           this.Action = "changeSortOrder";
        }
    }
}
