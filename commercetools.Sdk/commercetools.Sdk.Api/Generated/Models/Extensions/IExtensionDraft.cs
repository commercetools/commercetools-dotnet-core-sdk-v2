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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionDraft))]
    public partial interface IExtensionDraft
    {
        string Key { get; set; }

        IExtensionDestination Destination { get; set; }

        IList<IExtensionTrigger> Triggers { get; set; }
        IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }


        int? TimeoutInMs { get; set; }

    }
}
