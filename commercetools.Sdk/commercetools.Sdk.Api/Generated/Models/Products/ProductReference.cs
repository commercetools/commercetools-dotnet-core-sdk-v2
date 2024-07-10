using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductReference : IProductReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProduct Obj { get; set; }
        public ProductReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product");
        }
    }
}
