using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionTrigger : IExtensionTrigger
    {
        public IExtensionResourceTypeId ResourceTypeId { get; set; }

        public IList<IExtensionAction> Actions { get; set; }
        public IEnumerable<IExtensionAction> ActionsEnumerable { set => Actions = value.ToList(); }


        public string Condition { get; set; }
    }
}
