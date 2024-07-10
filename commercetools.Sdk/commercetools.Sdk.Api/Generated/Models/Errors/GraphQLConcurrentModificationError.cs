using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLConcurrentModificationError : IGraphQLConcurrentModificationError
    {
        public string Code { get; set; }

        public long? CurrentVersion { get; set; }
        public GraphQLConcurrentModificationError()
        {
            this.Code = "ConcurrentModification";
        }
    }
}
