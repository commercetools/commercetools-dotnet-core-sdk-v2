using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldTimeType : ICustomFieldTimeType
    {
        public string Name { get; set; }
        public CustomFieldTimeType()
        {
            this.Name = "Time";
        }
    }
}
