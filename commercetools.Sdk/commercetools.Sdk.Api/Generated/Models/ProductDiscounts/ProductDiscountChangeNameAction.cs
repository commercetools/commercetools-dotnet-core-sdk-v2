using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountChangeNameAction : IProductDiscountChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductDiscountChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
