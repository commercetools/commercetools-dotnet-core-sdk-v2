using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class Extension : IExtension
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IExtensionDestination Destination { get; set; }

        public IList<IExtensionTrigger> Triggers { get; set; }
        public IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }


        public int? TimeoutInMs { get; set; }
    }
}
