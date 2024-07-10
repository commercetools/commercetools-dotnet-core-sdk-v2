using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldBooleanType : ICustomFieldBooleanType
    {
        public string Name { get; set; }
        public CustomFieldBooleanType()
        {
            this.Name = "Boolean";
        }
    }
}
