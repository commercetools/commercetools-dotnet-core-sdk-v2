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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdate))]
    public partial interface IExtensionUpdate
    {
        long Version { get; set; }

        IList<IExtensionUpdateAction> Actions { get; set; }
        IEnumerable<IExtensionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
