using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionUpdateAction : IExtensionUpdateAction
    {
        public string Action { get; set;}
    }
}
