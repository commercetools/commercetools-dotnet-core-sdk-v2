using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidItemShippingDetailsError : IGraphQLInvalidItemShippingDetailsError
    {
        public string Code { get; set; }

        public string Subject { get; set; }

        public string ItemId { get; set; }
        public GraphQLInvalidItemShippingDetailsError()
        {
            this.Code = "InvalidItemShippingDetails";
        }
    }
}
