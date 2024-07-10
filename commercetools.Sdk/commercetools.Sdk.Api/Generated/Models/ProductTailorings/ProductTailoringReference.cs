using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringReference : IProductTailoringReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductTailoring Obj { get; set; }
        public ProductTailoringReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-tailoring");
        }
    }
}
