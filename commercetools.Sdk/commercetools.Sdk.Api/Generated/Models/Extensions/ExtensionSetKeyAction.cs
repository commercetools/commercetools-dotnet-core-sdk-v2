using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetKeyAction : IExtensionSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ExtensionSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
