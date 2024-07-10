using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldLocalizedEnumType : ICustomFieldLocalizedEnumType
    {
        public string Name { get; set; }

        public IList<ICustomFieldLocalizedEnumValue> Values { get; set; }
        public IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public CustomFieldLocalizedEnumType()
        {
            this.Name = "LocalizedEnum";
        }
    }
}
