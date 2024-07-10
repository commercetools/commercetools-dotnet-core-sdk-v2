using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInsufficientScopeError : IGraphQLInsufficientScopeError
    {
        public string Code { get; set; }
        public GraphQLInsufficientScopeError()
        {
            this.Code = "insufficient_scope";
        }
    }
}
