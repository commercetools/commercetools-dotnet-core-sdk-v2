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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError))]
    public partial interface IMissingRoleOnChannelError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        IChannelRoleEnum MissingRole { get; set; }

    }
}
