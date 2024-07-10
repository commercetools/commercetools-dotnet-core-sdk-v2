using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMissingRoleOnChannelError : IGraphQLMissingRoleOnChannelError
    {
        public string Code { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public IChannelRoleEnum MissingRole { get; set; }
        public GraphQLMissingRoleOnChannelError()
        {
            this.Code = "MissingRoleOnChannel";
        }
    }
}
