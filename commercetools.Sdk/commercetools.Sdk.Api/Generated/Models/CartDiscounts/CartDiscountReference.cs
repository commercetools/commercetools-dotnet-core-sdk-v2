using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountReference : ICartDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICartDiscount Obj { get; set; }
        public CartDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart-discount");
        }
    }
}
