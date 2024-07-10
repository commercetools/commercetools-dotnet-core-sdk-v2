using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionNoResponseError : IGraphQLExtensionNoResponseError
    {
        public string Code { get; set; }

        public string ExtensionId { get; set; }

        public string ExtensionKey { get; set; }
        public GraphQLExtensionNoResponseError()
        {
            this.Code = "ExtensionNoResponse";
        }
    }
}
