using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldEnumType : ICustomFieldEnumType
    {
        public string Name { get; set; }

        public IList<ICustomFieldEnumValue> Values { get; set; }
        public IEnumerable<ICustomFieldEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public CustomFieldEnumType()
        {
            this.Name = "Enum";
        }
    }
}
