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

    public partial class ProductDiscountReference : IProductDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductDiscount Obj { get; set; }
        public ProductDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-discount");
        }
    }
}
