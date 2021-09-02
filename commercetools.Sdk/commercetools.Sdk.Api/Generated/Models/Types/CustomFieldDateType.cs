using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldDateType : ICustomFieldDateType
    {
        public string Name { get; set; }
        public CustomFieldDateType()
        {
            this.Name = "Date";
        }
    }
}
