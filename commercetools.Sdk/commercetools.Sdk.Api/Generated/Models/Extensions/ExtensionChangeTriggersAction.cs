using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionChangeTriggersAction : IExtensionChangeTriggersAction
    {
        public string Action { get; set; }

        public IList<IExtensionTrigger> Triggers { get; set; }
        public IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }

        public ExtensionChangeTriggersAction()
        {
            this.Action = "changeTriggers";
        }
    }
}
