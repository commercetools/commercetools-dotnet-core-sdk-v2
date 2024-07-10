using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    public partial interface IExtensionChangeDestinationAction : IExtensionUpdateAction
    {
        IExtensionDestination Destination { get; set; }

    }
}
