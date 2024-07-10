using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLRequiredFieldError : IGraphQLRequiredFieldError
    {
        public string Code { get; set; }

        public string Field { get; set; }
        public GraphQLRequiredFieldError()
        {
            this.Code = "RequiredField";
        }
    }
}
