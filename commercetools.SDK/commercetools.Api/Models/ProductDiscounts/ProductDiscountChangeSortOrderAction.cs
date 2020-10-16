using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeSortOrder")]
    public partial class ProductDiscountChangeSortOrderAction : ProductDiscountUpdateAction
    {
        public string SortOrder { get; set;}
        public ProductDiscountChangeSortOrderAction()
        { 
           this.Action = "changeSortOrder";
        }
    }
}
