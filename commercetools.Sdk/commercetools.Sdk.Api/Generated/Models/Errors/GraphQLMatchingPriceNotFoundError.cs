using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMatchingPriceNotFoundError : IGraphQLMatchingPriceNotFoundError
    {
        public string Code { get; set; }

        public string ProductId { get; set; }

        public int VariantId { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }
        public GraphQLMatchingPriceNotFoundError()
        {
            this.Code = "MatchingPriceNotFound";
        }
    }
}
