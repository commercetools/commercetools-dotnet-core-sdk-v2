using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLProductAssignmentMissingError : IGraphQLProductAssignmentMissingError
    {
        public string Code { get; set; }

        public IProductReference Product { get; set; }
        public GraphQLProductAssignmentMissingError()
        {
            this.Code = "ProductAssignmentMissing";
        }
    }
}
