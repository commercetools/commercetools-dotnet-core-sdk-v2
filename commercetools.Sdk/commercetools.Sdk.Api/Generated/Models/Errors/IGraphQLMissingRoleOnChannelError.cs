using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError))]
    public partial interface IGraphQLMissingRoleOnChannelError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        IChannelRoleEnum MissingRole { get; set; }

    }
}
