using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEditPreviewFailedError : IGraphQLEditPreviewFailedError
    {
        public string Code { get; set; }

        public IOrderEditPreviewFailure Result { get; set; }
        public GraphQLEditPreviewFailedError()
        {
            this.Code = "EditPreviewFailed";
        }
    }
}
