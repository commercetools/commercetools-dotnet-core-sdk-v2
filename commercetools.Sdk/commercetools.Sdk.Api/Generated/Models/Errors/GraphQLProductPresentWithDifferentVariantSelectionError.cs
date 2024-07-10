using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLProductPresentWithDifferentVariantSelectionError : IGraphQLProductPresentWithDifferentVariantSelectionError
    {
        public string Code { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantSelection ExistingVariantSelection { get; set; }
        public GraphQLProductPresentWithDifferentVariantSelectionError()
        {
            this.Code = "ProductPresentWithDifferentVariantSelection";
        }
    }
}
