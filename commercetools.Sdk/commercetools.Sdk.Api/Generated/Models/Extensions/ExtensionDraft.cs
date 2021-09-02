using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionDraft : IExtensionDraft
    {
        public string Key { get; set; }

        public IExtensionDestination Destination { get; set; }

        public List<IExtensionTrigger> Triggers { get; set; }

        public int? TimeoutInMs { get; set; }
    }
}
