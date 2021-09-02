using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountChangeIsActiveAction : IProductDiscountChangeIsActiveAction
    {
        public string Action { get; set; }

        public bool IsActive { get; set; }
        public ProductDiscountChangeIsActiveAction()
        {
            this.Action = "changeIsActive";
        }
    }
}
