using commercetools.Sdk.ImportApi.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldStringType : ICustomFieldStringType
    {
        public string Name { get; set; }
        public CustomFieldStringType()
        {
            this.Name = "String";
        }
    }
}
