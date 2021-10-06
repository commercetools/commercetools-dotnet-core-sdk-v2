using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class CustomObjectKeyReference : ICustomObjectKeyReference
    {
        public string Key { get; set; }

        public string TypeId { get; set; }

        public string Container { get; set; }
        public CustomObjectKeyReference()
        {
            this.TypeId = "key-value-document";
        }
    }
}
