using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.Extension))]
    public partial interface IExtension : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IExtensionDestination Destination { get; set; }

        IList<IExtensionTrigger> Triggers { get; set; }
        IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }


        int? TimeoutInMs { get; set; }

    }
}
