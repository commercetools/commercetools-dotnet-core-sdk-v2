using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetTimeoutInMsAction : IExtensionSetTimeoutInMsAction
    {
        public string Action { get; set; }

        public int? TimeoutInMs { get; set; }
        public ExtensionSetTimeoutInMsAction()
        {
            this.Action = "setTimeoutInMs";
        }
    }
}
